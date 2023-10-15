using Lab2_1.Data;

namespace Lab2_1.Sensors
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