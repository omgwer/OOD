using Lab1_1.lib.Duck;
using Lab1_1.lib.Duck.Fly;

using static Lab1_1.lib.DuckFunctions;

namespace Lab1_1 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MallardDuck mallardDuck;
            PlayWithDuck(mallardDuck);

            RedheadDuck redheadDuck;
            PlayWithDuck(redheadDuck);

            RubberDuck rubberDuck;
            PlayWithDuck(rubberDuck);

            DecoyDuck decoyDuck;
            PlayWithDuck(decoyDuck);

            ModelDuck modelDuck;
            PlayWithDuck(modelDuck);

            modelDuck.SetFlyBehavior(std::make_unique<FlyWithWings>());
            PlayWithDuck(modelDuck);
        }
    }
}