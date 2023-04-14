using MembersApp.Data;
using MembersApp.Patterns;

namespace MembersApp.UI
{
    public class TreeNodeObserverAdapter : IObserver
    {
        public TreeNodeObserverAdapter( TreeNode node ) 
        { 
            Node = node;
        }

        private TreeNode Node { get; }

        public void Update(ISubject subject, object? data)
        {
            var member = subject as Member;
            Node.Text = member.Name;
        }
    }
}
