using Lab2_1.Data;

namespace Lab2_1.Sensors
{
    public class HumidityHistoryStats : AbstractHistoryStats
    {
        public override void Update( WeatherInfo data )
        {
            if ( MinValue > data.Humidity )
            {
                MinValue = data.Humidity;
            }

            if ( MaxValue < data.Humidity )
            {
                MaxValue = data.Humidity;
            }

            AccValue += data.Humidity;
            ++CountAcc;

            Console.WriteLine( $"Max humidity {MaxValue}" );
            Console.WriteLine( $"Min humidity {MinValue}" );
            Console.WriteLine( $"Average humidity {AccValue / CountAcc}" );
            Console.WriteLine( $"---------------------------------" );
        }
    }
}