using Lab1_2.lib.Duck;
using Lab1_2.lib.Duck.Fly;
using static Lab1_2.lib.DuckFunctions;

namespace Lab1_2 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MallardDuck mallardDuck = new();
            PlayWithDuck(mallardDuck);

            RedheadDuck redheadDuck = new();
            PlayWithDuck(redheadDuck);

            RubberDuck rubberDuck = new();
            PlayWithDuck(rubberDuck);

            DecoyDuck decoyDuck = new();
            PlayWithDuck(decoyDuck);

            ModelDuck modelDuck = new();
            PlayWithDuck(modelDuck);

            modelDuck.SetFlyBehavior(new FlyWithWings());
            PlayWithDuck(modelDuck);
        }
    }
}