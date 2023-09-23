namespace Lab1_2.lib.Duck.Quack
{
    public class SqueakBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine( "Squeek!!!" );
        }
    }
}