using Lab1_1.lib.Duck.Fly;
using Lab1_1.lib.Duck.Quack;

namespace Lab1_1.lib.Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }
    }
}