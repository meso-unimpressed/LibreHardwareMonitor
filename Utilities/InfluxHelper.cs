using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InfluxDB.Collector;
using Mustachio;
using Newtonsoft.Json.Linq;
using OpenHardwareMonitor.GUI;
using OpenHardwareMonitor.Hardware;

namespace OpenHardwareMonitor.Utilities
{
    public static class InfluxHelper
    {
        public static readonly Dictionary<string, string> GlobalTags = new Dictionary<string, string>();
        public static readonly Dictionary<string, object> MustachioModel = new Dictionary<string, object>();

        public static void SetMustachioModel(string jsonpath)
        {
            var settings = Properties.Settings.Default;

            MustachioModel.Clear();
            MustachioModel.Add("machineName", Environment.MachineName);

            if(string.IsNullOrWhiteSpace(jsonpath)) return;

            var appdir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (string.IsNullOrWhiteSpace(appdir)) return;

            var projdatapath = Path.Combine(appdir, "project.json");
            if (File.Exists(projdatapath))
            {
                var projjson = JObject.Parse(File.ReadAllText(projdatapath));
                foreach (var property in projjson.Properties())
                {
                    if (MustachioModel.ContainsKey(property.Name))
                        MustachioModel[property.Name] = property.Value.ToString();
                    else MustachioModel.Add(property.Name, property.Value.ToString());
                }

                if (projjson.TryGetValue("influxUrl", StringComparison.InvariantCultureIgnoreCase, out var auxInfluxUrl))
                    settings.InfluxUrl = auxInfluxUrl.ToString();
                if (projjson.TryGetValue("influxDatabase", StringComparison.InvariantCultureIgnoreCase, out var auxInfluxDb))
                    settings.InfluxDatabase = auxInfluxDb.ToString();
                if (projjson.TryGetValue("influxUser", StringComparison.InvariantCultureIgnoreCase, out var auxInfluxUser))
                    settings.InfluxUser = auxInfluxUser.ToString();
                if (projjson.TryGetValue("influxPasswordSecure", StringComparison.InvariantCultureIgnoreCase, out var auxInfluxPassSec))
                    settings.InfluxPass = auxInfluxPassSec.ToString();
                if (projjson.TryGetValue("influxPasswordPlain", StringComparison.InvariantCultureIgnoreCase, out var auxInfluxPass))
                    SaveObfuscatedInfluxPassword(auxInfluxPass.ToString());
            }
        }


        public static void ParseTagsSettings()
        {
            var settings = Properties.Settings.Default;
            int i = 0;
            foreach (var key in settings.InfluxTagKeys)
            {
                var val = settings.InfluxTagValues[i];
                if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(val))
                {
                    i++;
                    continue;
                }
                var template = Parser.Parse(val);
                var res = template(MustachioModel);
                if (GlobalTags.ContainsKey(key)) GlobalTags[key] = res;
                else GlobalTags.Add(key, res);
                i++;
            }
        }

        public static void StartMetrics()
        {
            Metrics.Collector?.Dispose();

            var settings = Properties.Settings.Default;

            if (string.IsNullOrWhiteSpace(settings.InfluxUrl)) return;
            if (string.IsNullOrWhiteSpace(settings.InfluxDatabase)) return;

            var decodedPass = DecodeInfluxPassword();
            var insecure = string.IsNullOrWhiteSpace(decodedPass);
            var nouser = string.IsNullOrWhiteSpace(settings.InfluxUser);

            try
            {
                var collectorconfig = new CollectorConfiguration()
                    .Batch.AtInterval(settings.InfluxInterval)
                    .WriteTo.InfluxDB(
                        settings.InfluxUrl, settings.InfluxDatabase,
                        nouser ? null : settings.InfluxUser,
                        insecure ? null : decodedPass
                    );

                foreach (var tagkey in GlobalTags.Keys)
                {
                    var tagval = GlobalTags[tagkey];
                    collectorconfig.Tag.With(tagkey, tagval);
                }

                Metrics.Collector = collectorconfig.CreateCollector();
            }
            catch (Exception e) { }
        }

        public static string DecodeInfluxPassword()
        {
            var settings = Properties.Settings.Default;
            return Encoding.UTF8.GetString(Base58Encoding.Decode(settings.InfluxPass));
        }
        public static void SaveObfuscatedInfluxPassword(string pass)
        {
            var settings = Properties.Settings.Default;
            settings.InfluxPass = Base58Encoding.Encode(Encoding.UTF8.GetBytes(pass));
        }

        public static void ComputerCrawler(IComputer comp)
        {
            if(Metrics.Collector == null) return;
            foreach (var hardware in comp.Hardware)
            {
                HardwareCrawler(hardware);
            }
        }

        public static void HardwareCrawler(IHardware hardware)
        {
            foreach (var sensor in hardware.Sensors)
            {
                SendSensor(sensor);
            }

            foreach (var subhw in hardware.SubHardware)
            {
                HardwareCrawler(subhw);
            }
        }

        private static readonly string _ohmprfx = "ohm.";
        private static Dictionary<string, string> _tagdict = new Dictionary<string, string>();

        public static void SendSensor(ISensor sensor)
        {
            _tagdict.Clear();
            AddSensorTag("Sensor.Name", sensor.Name);
            AddSensorTag("Sensor.Id", sensor.Identifier.ToString());
            AddSensorTag("Sensor.Type", sensor.SensorType.ToString());
            AddSensorTag("Hardware.Name", sensor.Hardware.Name);
            AddSensorTag("Hardware.Id", sensor.Hardware.Identifier.ToString());
            AddSensorTag("Hardware.Type", sensor.Hardware.HardwareType.ToString());
            Metrics.Collector.Measure(_ohmprfx + "Sensor", sensor.Value ?? 0.0f, _tagdict);
        }

        public static void AddSensorTag(string key, string val)
        {
            _tagdict.Add(_ohmprfx + key, val);
        }
    }
}

