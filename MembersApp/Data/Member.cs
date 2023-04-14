using MembersApp.Patterns;

namespace MembersApp.Data
{
    public class Member : Observable
    {
        private string _name = string.Empty;

        public string Name 
        {
            get => _name; 
            set
            {
                _name = value;
                InvokeNotify();
            }
        }
    }
}
