using Lab2_2;
using Lab2_2.Sensors;

/*
        Задание 2 — Безопасное уведомление наблюдателей — 10 баллов
    В приложении Weather Station работа метода NotifyObservers может привести к неопределенному поведению, 
    если из метода Update наблюдатель выполнит удаление себя из списка наблюдателей. Придумайте и реализуйте решение для данной проблемы.
    Напишите модульный тест для данного сценария.
*/

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

wd.RemoveObserver(temperatureHistoryStats);

wd.SetMeasurements(10, 0.8, 761);
wd.SetMeasurements(-10, 0.8, 761);