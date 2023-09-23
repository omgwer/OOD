using Lab1_3.lib.Duck.Dance;
using Lab1_3.lib.Duck.Fly;
using Lab1_3.lib.Duck.Quack;

namespace Lab1_3.lib.Duck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck() : base(new FlyWithWings(), new QuackBehavior(), new MinuetDance())
        {
        }
    }
}