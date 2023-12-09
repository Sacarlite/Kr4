
using System.Windows.Forms;

namespace Kr4
{

    public interface IStudAdd
    {
        string name { get; }
        string surname { get; }
        string middlename { get; }
        object group { get; }
        bool gender { get; }
        DateTime birthday { get; }
        void InsertGroupComboBox(List<StudentGroup> group);

        void ClearFields();
        void ClearComboBox();
        void ShowForm();
        void CloseForm();
        event EventHandler TryToAdd;
        event EventHandler Exit;
        event EventHandler OpenForm;

    }
    public partial class StudAddForm : Form, IStudAdd
    {
        private bool closeFlag = true;
        const string ADD_FUNCTION_STRING = "-Добавить группу-";
        public StudAddForm()
        {

            InitializeComponent();
        }
        public void InsertGroupComboBox(List<StudentGroup> group)
        {
            GroupComboBox.Items.Add(ADD_FUNCTION_STRING);
            foreach (var item in group)
            {

                GroupComboBox.Items.Add(item.Group);
            }
        }

        public string name => NameTextBox.Text;

        public string surname => SurnameTextBox.Text;

        public string middlename => MiddleNameTextbox.Text;
        public object group => GroupComboBox.SelectedItem;

        public DateTime birthday => dateTimePicker.Value;

        public bool gender => MaleRadioButton.Checked;


        public event EventHandler? TryToAdd;
        public event EventHandler? OpenForm;
        public event EventHandler? Exit;


        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (GroupComboBox.SelectedItem.ToString() == "-Добавить группу-")
            {
                
                if (OpenForm != null) OpenForm(this, EventArgs.Empty);
                GroupComboBox.ResetText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TryToAdd != null) TryToAdd(this, EventArgs.Empty);
        }
        public void ShowForm()
        {
            this.Show();
        }

        public void ClearFields()
        {
            NameTextBox.Text = "";
            NameTextBox.Refresh();
            SurnameTextBox.Text = "";
            SurnameTextBox.Refresh();
            MiddleNameTextbox.Text = "";
            MiddleNameTextbox.Refresh();
            MaleRadioButton.Checked = false;
            MaleRadioButton.Refresh();
            FemaleRadioButton.Checked = false;
            FemaleRadioButton.Refresh();
            
            dateTimePicker.MaxDate= DateTime.Today;
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Refresh();
        }

        public void CloseForm()
        {
            closeFlag = false;
            this.Close();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            if (Exit != null) Exit(this, EventArgs.Empty);
        }

        public void ClearComboBox()
        {
            GroupComboBox.Items.Clear();
            GroupComboBox.Refresh();
        }

        private void StudAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            if (e.CloseReason == CloseReason.UserClosing&& closeFlag)
            {
                if (Exit != null) Exit(this, EventArgs.Empty);
            }

        }
    }
}
