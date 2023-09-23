using Lab1_3.lib.Duck;
using Lab1_3.lib.Duck.Fly;
using static Lab1_3.lib.DuckFunctions;

namespace Lab1_3 
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