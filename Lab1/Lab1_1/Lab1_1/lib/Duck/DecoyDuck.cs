using Lab1_1.lib.Duck.Fly;
using Lab1_1.lib.Duck.Quack;

namespace Lab1_1.lib.Duck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }
    }
}