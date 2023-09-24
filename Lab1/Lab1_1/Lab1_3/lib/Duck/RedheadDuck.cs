using Lab1_3.lib.Duck.Strategy;

namespace Lab1_3.lib.Duck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck() : base(FlyStrategy.FlyWithWings, QuackStrategy.Quack, DanceStrategy.DanceMinuet)
        {
        }
    }
}