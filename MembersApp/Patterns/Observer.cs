using System.Diagnostics;

namespace MembersApp.Patterns
{
    internal class Observer 
    {
        public Observer( IObservable observable, EventHandler handler ) 
        { 
            Observable = observable;
            Handler = handler;

            Observable.Notify += handler;
        }

        public IObservable  Observable { get; set; }

        private EventHandler Handler { get; set; }

        public void Unsubscribe()
        {
            Observable.Notify -= Handler;
        }
    }
}
