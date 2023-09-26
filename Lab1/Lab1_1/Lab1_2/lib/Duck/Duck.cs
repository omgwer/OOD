using Lab1_2.lib.Duck.Dance;
using Lab1_2.lib.Duck.Fly;
using Lab1_2.lib.Duck.Quack;

namespace Lab1_2.lib.Duck
{
    public class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
        private IDanceBehavior _danceBehavior;

        public Duck( IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, IDanceBehavior danceBehavior )
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
            _danceBehavior = danceBehavior;
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void SetQuackBehavior( IQuackBehavior quackBehavior )
        {
            _quackBehavior = quackBehavior ?? throw new NullReferenceException();
        }

        public void Swim()
        {
            Console.WriteLine( "I`m swimming" );
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void SetFlyBehavior( IFlyBehavior flyBehavior )
        {
            _flyBehavior = flyBehavior ?? throw new NullReferenceException(); ;
        }

        public void Dance()
        {
            _danceBehavior.Dance();
        }

        public void SetDanceBehavior( IDanceBehavior danceBehavior )
        {
            _danceBehavior = danceBehavior ?? throw new NullReferenceException(); ;
        }

        public virtual void Display() { }
    }
}