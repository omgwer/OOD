namespace Lab2_4.Interfaces
{
    public interface IObserver<T>
    {
        public void Update( T data );
    }
}