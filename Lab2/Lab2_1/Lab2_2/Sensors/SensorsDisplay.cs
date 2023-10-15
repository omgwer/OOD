using Lab2_2.Data;

namespace Lab2_2.Sensors
{
    public class SensorsDisplay : Interfaces.IObserver<WeatherInfo>
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