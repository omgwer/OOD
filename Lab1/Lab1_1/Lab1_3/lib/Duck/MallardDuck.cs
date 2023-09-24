using Lab1_3.lib.Duck.Strategy;

namespace Lab1_3.lib.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(FlyStrategy.FlyWithWings, QuackStrategy.Quack, DanceStrategy.DanceWaltz)
        {
        }
    }
}