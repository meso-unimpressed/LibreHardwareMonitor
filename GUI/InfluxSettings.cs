using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Utilities;

namespace OpenHardwareMonitor.GUI
{
    public partial class InfluxSettings : Form
    {
        public InfluxSettings()
        {
            var settings = Properties.Settings.Default;
            InitializeComponent();
            TemplateJson.Text = settings.TemplatePath;
            TagsSettingsToTable();
            UpdateJson();
            InfluxEnabled.Checked = settings.InfluxEnabled;
            Interval.Text = settings.InfluxInterval.TotalSeconds.ToString(CultureInfo.InvariantCulture.NumberFormat);
        }

        private void UpdateJson()
        {
            var settings = Properties.Settings.Default;
            settings.TemplatePath = TemplateJson.Text;
            InfluxHelper.SetMustachioModel(TemplateJson.Text);
            TemplateTableView.Rows.Clear();
            foreach (var tempvar in InfluxHelper.MustachioModel.Keys)
            {
                var val = InfluxHelper.MustachioModel[tempvar];
                TemplateTableView.Rows.Add(tempvar, val);
            }
            InfluxHelper.ParseTagsSettings();

            Url.Text = settings.InfluxUrl;
            Database.Text = settings.InfluxDatabase;
            InfluxUser.Text = settings.InfluxUser;
            InfluxPassword.Text = InfluxHelper.DecodeInfluxPassword();
            _invalidTableChange = false;
        }

        private bool _invalidTableChange = true;

        private void TagTableChanged()
        {
            var settings = Properties.Settings.Default;
            settings.InfluxTagKeys.Clear();
            settings.InfluxTagValues.Clear();
            for (int i = 0; i < TagsTableView.RowCount; i++)
            {
                var key = TagsTableView.Rows[i].Cells[0].Value?.ToString();
                var val = TagsTableView.Rows[i].Cells[1].Value?.ToString();
                if (string.IsNullOrWhiteSpace(key)) continue;
                if (string.IsNullOrWhiteSpace(val)) continue;

                settings.InfluxTagKeys.Add(key);
                settings.InfluxTagValues.Add(val);
            }
        }

        private void SaveSettings()
        {
            var settings = Properties.Settings.Default;
            settings.InfluxUrl = Url.Text;
            settings.InfluxDatabase = Database.Text;
            settings.InfluxUser = InfluxUser.Text;
            InfluxHelper.SaveObfuscatedInfluxPassword(InfluxPassword.Text);
            settings.InfluxEnabled = InfluxEnabled.Checked;
            settings.InfluxInterval = TimeSpan.FromSeconds((double)Interval.DecimalValue);
            UpdateJson();
            TagTableChanged();
            settings.Save();
        }

        private void TagsSettingsToTable()
        {
            _invalidTableChange = true;

            TagsTableView.Rows.Clear();
            var settings = Properties.Settings.Default;
            int i = 0;
            foreach (var key in settings.InfluxTagKeys)
            {
                var val = settings.InfluxTagValues[i];
                TagsTableView.Rows.Add(key, val);
                i++;
            }
            _invalidTableChange = false;
        }

        private void OnApplyTemplate(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            settings.InfluxUrl = Url.Text;
            settings.InfluxDatabase = Database.Text;
            settings.InfluxUser = InfluxUser.Text;
            InfluxHelper.SaveObfuscatedInfluxPassword(InfluxPassword.Text);
            UpdateJson();
            InfluxHelper.StartMetrics();
        }

        private void OnEnabledChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.InfluxEnabled = InfluxEnabled.Checked;
        }

        private void OnTagsCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(_invalidTableChange) return;
            TagTableChanged();
        }

        private void OnApplySettings(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void OnConfirmSettings(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
