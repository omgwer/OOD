
/*
 Задание 4 — Наблюдение за несколькими субъектами — 20 баллов
    От заказчика поступил запрос на разработку приложения Weather Station Duo, предназначенного для работы с новейшими устройствами, имеющими 2 метеостанции. 
    Такие устройства позволяют один набор датчиков разместить внутри помещения, а другой - снаружи. Соответственно, в такой программе существуют 2 объекта WeatherData.
    Индикаторы в программе должны стать продвинутыми — теперь каждый индикатор в такой программе отображает показатели сразу с двух станций (in и out). 
    Придумайте решение, позволяющее наблюдателю узнать, от какого субъекта было получено уведомление.
    Напишите модульный тест для данного функционала.
*/

using Lab2_4;
using Lab2_4.Sensors;

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
