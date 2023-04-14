namespace MembersApp.Patterns
{
    public class Subject : ISubject
    {
        private IList<IObserver> Observers { get; } = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            if (Observers.Contains(observer)) return;
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (! Observers.Contains(observer)) return;
            Observers.Remove(observer);
        }

        public void Notify(object? data = null)
        {
            foreach (var observer in Observers)
                observer.Update(this, data);
        }
    }
}
