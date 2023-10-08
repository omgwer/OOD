using Lab2_1.Data;

namespace Lab2_1.Implementation
{
    public class WeatherData : Observable<WeatherInfo>
    {
        private double
            _temperature = 0.0,
            _humidity = 0.0,
            _pressure = 760.0;
        
        public void SetMeasurements( double temp, double humidity, double pressure )
        {
            _pressure = pressure;
            _temperature = temp;
            _humidity = humidity;
            
            MeasurementsChanged();
        }
        
        protected override WeatherInfo GetChangedData()
        {
            WeatherInfo info = new ()
            {
                Temperature = GetTemperature(),
                Humidity = GetHumidity(),
                Pressure = GetPressure()
            };
            return info;
        }

        private double GetTemperature()
        {
            return _temperature;
        }

        private double GetHumidity()
        {
            return _humidity;
        }

        private double GetPressure()
        {
            return _pressure;
        }
        
        private void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}