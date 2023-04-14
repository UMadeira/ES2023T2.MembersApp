using MembersApp.Data;
using MembersApp.Patterns;
using System.ComponentModel;

namespace MembersApp.UI
{
    public class ToolStripObserverAdapter : IObserver
    {
        public ToolStripObserverAdapter( ToolStripItem item ) 
        {
            Item = item;
        }

        private ToolStripItem Item { get; }

        public void Update(ISubject subject, object? data)
        {
            var member = subject as Member;
            if (member == null) return;

            Item.Text = member.Name;
        }
    }
}
