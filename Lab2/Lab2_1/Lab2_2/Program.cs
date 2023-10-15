
using Lab2_1;
using Lab2_1.Sensors;

WeatherData wd = new ();

SensorsDisplay sensorsDisplay = new ();
wd.RegisterObserver(sensorsDisplay);

TemperatureHistoryStats temperatureHistoryStats = new ();
wd.RegisterObserver(temperatureHistoryStats);

HumidityHistoryStats humidityHistoryStats = new();
wd.RegisterObserver(humidityHistoryStats );

PressureHistoryStats pressureHistoryStats = new();
wd.RegisterObserver( pressureHistoryStats );


wd.SetMeasurements(3, 0.7, 760);
wd.SetMeasurements(4, 0.8, 761);
//
// wd.RemoveObserver(temperatureHistoryStats);
//
// wd.SetMeasurements(10, 0.8, 761);
// wd.SetMeasurements(-10, 0.8, 761);