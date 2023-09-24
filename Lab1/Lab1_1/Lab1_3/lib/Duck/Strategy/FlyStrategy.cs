
namespace Lab1_3.lib.Duck.Strategy
{
    public static class FlyStrategy
    {
        public static readonly Func<Action> FlyNoWay = () =>
        {
            return () => { };
        };

        public static readonly Func<Action> FlyWithWings = () =>
        {
            int flyCount = 0;
            return () =>
            {
                flyCount++;
                Console.WriteLine($"I'm flying with wings for the {flyCount}th time!!");
            };
        };
    }
}




