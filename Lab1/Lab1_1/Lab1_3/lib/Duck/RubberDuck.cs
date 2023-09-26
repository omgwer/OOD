using Lab1_3.lib.Duck.Strategy;

namespace Lab1_3.lib.Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base( FlyStrategy.FlyNoWay, QuackStrategy.Squeak, DanceStrategy.DanceNoWay )
        {
        }
    }
}