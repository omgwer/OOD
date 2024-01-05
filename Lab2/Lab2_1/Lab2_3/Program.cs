
/*
       Задание 3 — Приоритеты наблюдателей — 30 баллов
    В приложении Weather Station порядок оповещения наблюдателей заранее неизвестен. 
    Доработайте приложение таким образом, чтобы при регистрации наблюдателя можно было задать его приоритет в виде целого числа. 
    Наблюдатели с более высоким приоритетом должны получать оповещения от субъекта раньше, чем наблюдатели с более низким приоритетом.
    Если наблюдатель уже подписан, то повторная подписка не должна выполняться.
    Методы RegisterObserver, RemoveObserver должны иметь сложность лучше линейной.
    Напишите модульный тест для данного функционала.
*/

using Lab2_3;
using Lab2_3.Sensors;

WeatherData wd = new ();

SensorsDisplay sensorsDisplay = new ();
wd.RegisterObserver(sensorsDisplay, 1);

TemperatureHistoryStats temperatureHistoryStats = new ();
wd.RegisterObserver(temperatureHistoryStats, 3);

HumidityHistoryStats humidityHistoryStats = new();
wd.RegisterObserver(humidityHistoryStats , 2);

PressureHistoryStats pressureHistoryStats = new();
wd.RegisterObserver( pressureHistoryStats, 3 );


wd.SetMeasurements(3, 0.7, 760);
wd.SetMeasurements(4, 0.8, 761);

wd.RemoveObserver(temperatureHistoryStats);

wd.SetMeasurements(10, 0.8, 761);
wd.SetMeasurements(-10, 0.8, 761);
