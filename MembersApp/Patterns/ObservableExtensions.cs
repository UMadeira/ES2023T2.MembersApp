namespace MembersApp.Patterns
{
    internal static class ObservableExtensions
    {
        public static Observer Subscribe( this Observable observable, EventHandler handler ) 
        {
            return new Observer( observable, handler );
        }
    }
}
