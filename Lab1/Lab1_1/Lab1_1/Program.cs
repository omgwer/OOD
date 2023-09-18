namespace Lab1_1 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Shapes shapes = new Shapes(Console.In, Console.Out);
            while ( shapes.IsRun )
            {
                shapes.HandleInput();
            }
        }
    }
}