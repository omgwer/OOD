using Lab1_3.lib.Duck.Dance;
using Lab1_3.lib.Duck.Fly;
using Lab1_3.lib.Duck.Quack;

namespace Lab1_3.lib.Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWay(), new SqueakBehavior(), new DanceNoWay())
        {
        }
    }
}