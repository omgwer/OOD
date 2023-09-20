using Lab1_1.lib.Duck.Fly;
using Lab1_1.lib.Duck.Quack;

namespace Lab1_1.lib.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }
    }
}