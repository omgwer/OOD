
namespace Lab1_3.lib.Duck.Strategy
{
    public static class DanceStrategy
    {
        public static readonly Func<Action> DanceNoWay = () =>
        {
            return () => { };
        };
        
        public static readonly Func<Action> DanceWaltz = () =>
        {
            return () =>
            {
                Console.WriteLine( "Waltz dance" );
            };
        };
        
        public static readonly Func<Action> DanceMinuet = () =>
        {
            return () =>
            {
                Console.WriteLine( "Minuet dance!" );
            };
        };
    }
}