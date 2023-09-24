
using Lab1_3.lib.Duck.Strategy;

namespace Lab1_3.lib.Duck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(FlyStrategy.FlyNoWay, QuackStrategy.QuackNoWay(), DanceStrategy.DanceNoWay)
        {
        }
    }
}