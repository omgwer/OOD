namespace Lab2_2.Interfaces
{
    public interface IObserver<T>
    {
        public void Update( T data );
    }
}