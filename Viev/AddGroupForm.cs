
namespace Kr4
{
    public interface IAddGroup
    {
        string groupName { get; }
        void ShowForm();
        void ClearFields();
        void CloseForm();
        event EventHandler TryToAddGroup;
        event EventHandler Exit;
    }

    public partial class AddGroupForm : Form, IAddGroup
    {
        private bool closeFlag = true;
        public AddGroupForm()
        {
            InitializeComponent();
        }

        public string groupName
        {
            get
            {
                return GroupTextBox.Text;
            }
        }

        public event EventHandler? TryToAddGroup;
        public event EventHandler? Exit;
       
        public void ClearFields()
        {
            GroupTextBox.Text = "";
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm()
        {
            this.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (Exit != null) Exit(this, EventArgs.Empty);
            closeFlag = false;
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            if (TryToAddGroup != null) TryToAddGroup(this, EventArgs.Empty);
        }

        private void AddGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing&& closeFlag)
            {
                if (Exit != null) Exit(this, EventArgs.Empty);
            }
        }
    }
}
