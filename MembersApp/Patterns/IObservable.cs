namespace MembersApp.Patterns
{
    public interface IObservable
    {
        event EventHandler Notify;
    }
}
