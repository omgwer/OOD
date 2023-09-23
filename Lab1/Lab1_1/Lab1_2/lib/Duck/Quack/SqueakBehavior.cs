namespace Lab1_1.lib.Duck.Quack
{
    public class SqueakBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine( "Squeek!!!" );
        }
    }
}