namespace Lab2_2.Interfaces
{
    public interface IObservable<T>
    {
        public void RegisterObserver( IObserver<T> observer, int priority );
        public void NotifyObservers();
        public void RemoveObserver( IObserver<T> observer );
    }
}