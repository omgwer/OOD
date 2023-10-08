
using Lab2_1.Implementation;

WeatherData wd = new ();

Display display = new ();
wd.RegisterObserver(display);

StatsDisplay statsDisplay = new ();
wd.RegisterObserver(statsDisplay);

wd.SetMeasurements(3, 0.7, 760);
wd.SetMeasurements(4, 0.8, 761);

wd.RemoveObserver(statsDisplay);

wd.SetMeasurements(10, 0.8, 761);
wd.SetMeasurements(-10, 0.8, 761);