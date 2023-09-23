namespace Lab1_3.lib.Duck.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        private uint _flyCounter = 0;
        public void Fly()
        {
            _flyCounter++;
            Console.WriteLine($"I'm flying with wings for the {_flyCounter} time!!");
        }
    }
}