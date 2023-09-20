using Lab1_1.lib.Duck.Fly;
using Lab1_1.lib.Duck.Quack;

namespace Lab1_1.lib.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }
    }
}