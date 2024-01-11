using Lab2_4.Data;

namespace Lab2_4.Sensors
{
    public class PressureHistoryStats : AbstractHistoryStats
    {
        public override void Update( WeatherInfo data )
        {
            if ( MinValue > data.Pressure )
            {
                MinValue = data.Pressure;
            }

            if ( MaxValue < data.Pressure )
            {
                MaxValue = data.Pressure;
            }

            AccValue += data.Pressure;
            ++CountAcc;

            Console.WriteLine( $"Max pressure {MaxValue}" );
            Console.WriteLine( $"Min pressure {MinValue}" );
            Console.WriteLine( $"Average pressure {double.Round( AccValue / CountAcc, 2 )}" );
            Console.WriteLine( $"---------------------------------" );
        }
    }
}