using Lab1_2.lib.Duck.Dance;
using Lab1_2.lib.Duck.Fly;
using Lab1_2.lib.Duck.Quack;

namespace Lab1_2.lib.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(new FlyNoWay(), new QuackBehavior(), new DanceNoWay())
        {
        }
    }
}