using Lab2_3.Data;

namespace Lab2_3.Sensors
{
    public class TemperatureHistoryStats : AbstractHistoryStats
    {
        public override void Update( WeatherInfo data )
        {
            if ( MinValue > data.Temperature )
            {
                MinValue = data.Temperature;
            }

            if ( MaxValue < data.Temperature )
            {
                MaxValue = data.Temperature;
            }

            AccValue += data.Temperature;
            ++CountAcc;

            Console.WriteLine( $"Max Temp {MaxValue}" );
            Console.WriteLine( $"Min Temp {MinValue}" );
            Console.WriteLine( $"Average Temp {AccValue / CountAcc}" );
            Console.WriteLine( $"---------------------------------" );
        }
    }
}