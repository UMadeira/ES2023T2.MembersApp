using System.Diagnostics;

namespace MembersApp.Patterns
{
    public class Observable : IObservable
    {
        public event EventHandler? Notify;

        protected void InvokeNotify()
        {
            Trace.WriteLine($"Event Handlers: {Notify?.GetInvocationList().Length ?? 0} ");
            Notify?.Invoke(this, EventArgs.Empty);
        }
    }
}
