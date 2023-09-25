namespace Lab1_3.lib.Duck.Strategy
{
    public static class QuackStrategy
    {
        public static Action QuackNoWay = () =>
        {
        };

        public static Action Quack = () =>
        {
            Console.WriteLine( "Quack Quack!!!" );
        };

        public static Action Squeak = () =>
        {
            Console.WriteLine( "Squeek!!!" );
        };
    }
}