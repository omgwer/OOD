using Lab1_1.lib.Duck.Dance;
using Lab1_1.lib.Duck.Fly;
using Lab1_1.lib.Duck.Quack;

namespace Lab1_1.lib.Duck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base( new FlyNoWay(), new MuteQuackBehavior(), new DanceNoWay() )
        {
        }
    }
}