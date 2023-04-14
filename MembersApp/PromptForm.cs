namespace MembersApp
{
    public partial class PromptForm : Form
    {
        public PromptForm()
        {
            InitializeComponent();

            ActiveControl = valueTextBox;
        }

        public string Title
        {
            get => this.Text;
            set => this.Text = value;
        }

        public string Label
        {
            get => labelLabel.Text;
            set => labelLabel.Text = value;
        }

        public string Value
        {
            get => valueTextBox.Text;
            set => valueTextBox.Text = value;
        }
    }
}
