namespace Lab1_3.lib.Duck.Strategy
{
    public static class QuackStrategy
    {
        public static Action QuackNoWay()
        {
            return () => { };
        }

        public static Action Quack()
        {
            return () =>
            {
                Console.WriteLine( "Quack Quack!!!" );
            };
        }

        public static Action Squeak()
        {
            return () =>
            {
                Console.WriteLine( "Squeek!!!" );
            };
        }
    }
}