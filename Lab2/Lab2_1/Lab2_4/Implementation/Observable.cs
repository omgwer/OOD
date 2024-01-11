using Lab2_4.Comparer;

namespace Lab2_4.Implementation
{
    public abstract class Observable<T> : Interfaces.IObservable<T>
    {
        private SortedDictionary<int, HashSet<Interfaces.IObserver<T>>> _observers = new(new SortedDictionaryComparer());
        SortedSet<Interfaces.IObserver<T>> _observersToRemove = new();

        protected abstract T GetChangedData();

        public void RegisterObserver( Interfaces.IObserver<T> observer, int priority )
        {
            if ( _observers.ContainsKey( priority ) )
            {
                _observers[ priority ].Add( observer );
            }
            else
            {
                _observers.Add( priority, new HashSet<Interfaces.IObserver<T>>
                {
                    observer
                } );
            }
        }

        public void NotifyObservers()
        {
            T data = GetChangedData();

            foreach ( ( int _, HashSet<Interfaces.IObserver<T>> value ) in _observers )
            {
                foreach ( Interfaces.IObserver<T> observer in value )
                {
                    observer.Update( data );
                }
            }
          
            foreach ( Interfaces.IObserver<T> observer in _observersToRemove )
            {
                HashSet<Interfaces.IObserver<T>> findedValue  = _observers.Values.First( e => e.Contains( observer ) );
                findedValue.Remove( observer );
            }

            _observersToRemove.Clear();
        }

        public void RemoveObserver( Interfaces.IObserver<T> observer )
        {
            _observersToRemove.Add( observer );
        }
    }
}