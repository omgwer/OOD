using Lab2_1.Data;

namespace Lab2_1.Implementation
{
    public class StatsDisplay : Interfaces.IObserver<WeatherInfo>
    {
        private double _minTemperature = double.MinValue;
        private double _maxTemperature = double.MaxValue;
        private double _accTemperature = 0;
        private uint _countAcc = 0;
        
        public void Update( WeatherInfo data )
        {
            if ( _minTemperature > data.Temperature )
            {
                _minTemperature = data.Temperature;
            }

            if ( _maxTemperature < data.Temperature )
            {
                _maxTemperature = data.Temperature;
            }

            _accTemperature += data.Temperature;
            ++_countAcc;

            Console.WriteLine( $"Max Temp {_maxTemperature}" );
            Console.WriteLine( $"Min Temp {_minTemperature}" );
            Console.WriteLine( $"Average Temp {_accTemperature / _countAcc}" );
            Console.WriteLine( $"---------------------------------" );
        }
    }
}