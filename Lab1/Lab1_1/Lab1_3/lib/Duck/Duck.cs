
namespace Lab1_3.lib.Duck
{
    // TODO: Поправить , сделать абстрактный класс
    public  class Duck
    {
        private Action _flyBehavior;
        private Action _quackBehavior;
        private Action _danceBehavior;

        public Duck( Action flyBehavior, Action quackBehavior, Action danceBehavior )
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
            _danceBehavior = danceBehavior;
        }

        public void Quack()
        {
            _quackBehavior();
        }

        public void SetQuackBehavior( Action quackBehavior )
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

        public void SetFlyBehavior( Action flyBehavior )
        {
            _flyBehavior = flyBehavior ?? throw new NullReferenceException(); ;
        }

        public void Dance()
        {
            _danceBehavior();
        }

        public void SetDanceBehavior( Action danceBehavior )
        {
            _danceBehavior = danceBehavior ?? throw new NullReferenceException(); ;
        }

        public abstract void Display();
    }
}