using Lab2_1.Data;

namespace Lab2_1.Implementation
{
    public class Display : Interfaces.IObserver<WeatherInfo>
    {
        public void Update( WeatherInfo data )
        {
            Console.WriteLine( $"Current Temp {data.Temperature}" );
            Console.WriteLine( $"Current Hum {data.Humidity}" );
            Console.WriteLine( $"Current Pressure {data.Pressure}" );
            Console.WriteLine( "-----------------------------");
        }
    }
}