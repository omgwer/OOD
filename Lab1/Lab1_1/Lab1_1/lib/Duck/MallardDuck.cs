using Lab1_1.lib.Duck.Dance;
using Lab1_1.lib.Duck.Fly;
using Lab1_1.lib.Duck.Quack;

namespace Lab1_1.lib.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base( new FlyWithWings(), new QuackBehavior(), new WaltzDance() )
        {
        }
    }
}