using Lab1_3.lib.Duck;
using static Lab1_3.lib.DuckFunctions;

namespace Lab1_3
{
    internal class Program
    {
        public static void Main( string[] args )
        {
            MallardDuck mallardDuck = new();
            PlayWithDuck( mallardDuck );

            PlayWithDuck( mallardDuck );

            // RedheadDuck redheadDuck = new();
            // PlayWithDuck(redheadDuck);
            //
            // RubberDuck rubberDuck = new();
            // PlayWithDuck(rubberDuck);
            //
            // DecoyDuck decoyDuck = new();
            // PlayWithDuck(decoyDuck);
            //
            // ModelDuck modelDuck = new();
            // PlayWithDuck(modelDuck);
            //
            // modelDuck.SetFlyBehavior(FlyStrategy.FlyWithWings);
            // PlayWithDuck(modelDuck);
        }
    }
}