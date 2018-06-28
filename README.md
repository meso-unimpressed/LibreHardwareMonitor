# OpenHardwareMonitor + InfluxDB

This is a fork of Libre Hardware Monitor which is a fork of Open Hardware Monitor, where you can connect to an InfluxDB instance and send sensor values to it.

All sensors are sent as `ohm.Sensor` measurement with tags:

* ohm.Name
* ohm.Identifier
* ohm.Type
* ohm.Hardware.Name
* ohm.Hardware.Identifier
* ohm.Hardware.Type
