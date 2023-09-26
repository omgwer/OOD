
using Lab1_3.lib.Duck.Strategy;

namespace Lab1_3.lib.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base( FlyStrategy.FlyNoWay, QuackStrategy.Quack, DanceStrategy.DanceNoWay )
        {
        }
    }
}