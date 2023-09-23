namespace Lab1_3.lib.Duck.Quack
{
    public class SqueakBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine( "Squeek!!!" );
        }
    }
}