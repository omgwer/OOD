using Lab1_2.lib.Duck.Dance;
using Lab1_2.lib.Duck.Fly;
using Lab1_2.lib.Duck.Quack;

namespace Lab1_2.lib.Duck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck() : base(new FlyWithWings(), new QuackBehavior(), new MinuetDance())
        {
        }
    }
}