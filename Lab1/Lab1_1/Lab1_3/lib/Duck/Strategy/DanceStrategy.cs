
namespace Lab1_3.lib.Duck.Strategy
{
    public static class DanceStrategy
    {
        public static readonly Action DanceNoWay = () =>
        {
        };
        
        public static readonly Action DanceWaltz = () =>
        {
            Console.WriteLine( "Waltz dance" );
        };
        
        public static readonly Action DanceMinuet = () =>
        {
                Console.WriteLine( "Minuet dance!" );
        };
    }
}