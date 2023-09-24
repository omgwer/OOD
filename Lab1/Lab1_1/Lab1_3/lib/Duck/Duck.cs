
namespace Lab1_3.lib.Duck
{
    public class Duck
    {
        private Func<Action> _flyBehavior;
        private Action _quackBehavior;
        private Func<Action> _danceBehavior;

        public Duck(Func<Action> flyBehavior, Action quackBehavior, Func<Action> danceBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
            _danceBehavior = danceBehavior;
        }

        public void Quack()
        {
           _quackBehavior();
        }

        public void SetQuackBehavior(Action quackBehavior)
        {
            _quackBehavior = quackBehavior ?? throw new NullReferenceException();
        }

        public void Swim()
        {
            Console.WriteLine( "I`m swimming" );
        }

        public void Fly()
        {
            _flyBehavior();
        }
        
        public void SetFlyBehavior(Func<Action> flyBehavior)
        {
            _flyBehavior = flyBehavior ?? throw new NullReferenceException();;
        }

        public void Dance()
        {
            _danceBehavior();
        }
        
        public void SetDanceBehavior(Func<Action> danceBehavior)
        {
            _danceBehavior = danceBehavior ?? throw new NullReferenceException();;
        }

        public virtual void Display() { }
    }
}