using Lab1_1.lib.Duck.Fly;
using Lab1_1.lib.Duck.Quack;

namespace Lab1_1.lib.Duck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck() : base(new FlyWithWings(), new QuackBehavior())
        {
        }
    }
}