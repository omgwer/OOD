namespace Lab2_3.Interfaces
{
    public interface IObserver<T>
    {
        public void Update( T data );
    }
}