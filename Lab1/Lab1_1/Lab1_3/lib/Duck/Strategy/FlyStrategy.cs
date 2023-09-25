namespace Lab1_3.lib.Duck.Strategy
{
    public static class FlyStrategy
    {
        public static readonly Action FlyNoWay = () =>
        {
        };

        public static readonly Action FlyWithWings = () =>
        {
            int flyCount = 0;
            flyCount++;
            Console.WriteLine( $"I'm flying with wings for the {flyCount}th time!!" );
        };
    }
}