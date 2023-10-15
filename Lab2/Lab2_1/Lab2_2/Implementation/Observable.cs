namespace Lab2_2.Implementation
{
    public abstract class Observable<T> : Interfaces.IObservable<T>
    {
        private SortedSet<Interfaces.IObserver<T>> _observers = new ();
        private SortedSet<Interfaces.IObserver<T>> _observersToRemove = new ();
        
        
        protected abstract T GetChangedData();
        
        public void RegisterObserver( Interfaces.IObserver<T> observer, int priority )
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

            foreach ( Interfaces.IObserver<T> observer in _observersToRemove )
            {
                _observers.Remove( observer );
            }
            
            _observersToRemove.Clear();
        }

        public void RemoveObserver( Interfaces.IObserver<T> observer )
        {
            _observersToRemove.Add( observer );
        }
    }
}