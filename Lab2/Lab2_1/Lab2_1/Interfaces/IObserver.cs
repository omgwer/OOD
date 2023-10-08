namespace Lab2_1.Interfaces
{
    public interface IObserver<T>
    {
        public void Update( T data );
    }
}