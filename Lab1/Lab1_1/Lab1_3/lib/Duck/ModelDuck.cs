using Lab1_3.lib.Duck.Dance;
using Lab1_3.lib.Duck.Fly;
using Lab1_3.lib.Duck.Quack;

namespace Lab1_3.lib.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(new FlyNoWay(), new QuackBehavior(), new DanceNoWay())
        {
        }
    }
}