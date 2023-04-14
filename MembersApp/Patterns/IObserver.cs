namespace MembersApp.Patterns
{
    public interface IObserver
    {
        void Update( ISubject subject, object? data );
    }
}
