using Lab2_1.Data;

namespace Lab2_1.Implementation
{
    public class WeatherData : Observable<WeatherInfo>
    {
        private double
            _temperature = 0.0,
            _humidity = 0.0,
            _pressure = 760.0;

        protected override WeatherInfo GetChangedData()
        {
            throw new NotImplementedException();
        }

        public double GetTemperature()
        {
            return _temperature;
        }

        public double GetHimidity()
        {
            return _humidity;
        }

        public double GetPressure()
        {
            return _pressure;
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements( double temp, double humidity, double pressure )
        {
            _pressure = pressure;
            _temperature = temp;
            _humidity = humidity;
            
            MeasurementsChanged();
        }
    }
}