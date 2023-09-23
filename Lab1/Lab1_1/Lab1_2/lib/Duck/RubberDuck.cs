using Lab1_2.lib.Duck.Dance;
using Lab1_2.lib.Duck.Fly;
using Lab1_2.lib.Duck.Quack;

namespace Lab1_2.lib.Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWay(), new SqueakBehavior(), new DanceNoWay())
        {
        }
    }
}