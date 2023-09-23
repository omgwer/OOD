
namespace Lab1_1.lib
{
    public static class DuckFunctions
    {
        public static void DrawDuck(Duck.Duck duck)
        {
            duck.Display();
        }
        
        public static void PlayWithDuck(Duck.Duck duck)
        {
            DrawDuck(duck);
            duck.Quack();
            duck.Fly();
            duck.Dance();
            Console.WriteLine();
        }
    }
}