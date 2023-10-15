namespace Lab2_1.Implementation
{
    public abstract class Observable<T> : Interfaces.IObservable<T>
    {
        private HashSet<Interfaces.IObserver<T>> _observers = new ();
        
        protected abstract T GetChangedData();
        
        public void RegisterObserver( Interfaces.IObserver<T> observer )
        {
            _observers.Add( observer );
        }

        public void NotifyObservers()
        {
            T data = GetChangedData();
            foreach ( Interfaces.IObserver<T> observer in _observers)
            {
                observer.Update( data );
            }
        }

        public void RemoveObserver( Interfaces.IObserver<T> observer )
        {
            _observers.Remove( observer );
        }
    }
}