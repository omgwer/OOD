using Lab2_1.Data;

namespace Lab2_1.Sensors
{
    public abstract class AbstractHistoryStats : Interfaces.IObserver<WeatherInfo>
    {
        protected double MinValue = double.PositiveInfinity;
        protected double MaxValue = double.NegativeInfinity;
        protected double AccValue = 0;
        protected uint CountAcc = 0;
        
        public abstract void Update( WeatherInfo data );
    }
}