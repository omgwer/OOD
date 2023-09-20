using Lab1_1.lib.Duck.Fly;
using Lab1_1.lib.Duck.Quack;

namespace Lab1_1.lib.Duck
{
    public class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
        
        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine( "I`m swimming" );
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public virtual void Dance()
        {
            Console.WriteLine( "I`m dancing" );
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public virtual void Display() { }
    }
}