using Lab1_2.lib.Duck.Dance;
using Lab1_2.lib.Duck.Fly;
using Lab1_2.lib.Duck.Quack;

namespace Lab1_2.lib.Duck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base( new FlyNoWay(), new MuteQuackBehavior(), new DanceNoWay() )
        {
        }
    }
}