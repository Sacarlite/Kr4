
namespace Kr4.Viev
{
    public interface IStudChange
    {
        string name { get; set; }
        string surname { get; set; }
        string middlename { get; set; }
        object group { get; set; }
        bool gender { get; set; }
        DateTime birthday { get; set; }
        void InsertGroupComboBox(List<StudentGroup> group);
        void SelectGroupComboBox(StudentGroup group);
        void ClearFields();
        void ClearComboBox();
        void ShowForm();
        void CloseForm();
        void SetData();
        event EventHandler TryToChange;
        event EventHandler TryToDelete;
        event EventHandler OpenGroupAddForm;

    }

    public partial class StudentChangeForm : Form, IStudChange
    {
        const string ADD_FUNCTION_STRING = "-Добавить группу-";
        public StudentChangeForm()
        {
            InitializeComponent();
        }
        public string name
        {
            get
            {
                return ChngNameTextBox.Text;
            }
            set
            {
                ChngNameTextBox.Text = value;
                this.Refresh();
            }
        }

        public string surname
        {
            get
            {
                return ChngSurnameTextBox.Text;
            }
            set
            {
                ChngSurnameTextBox.Text = value;
                this.Refresh();
            }
        }

        public string middlename
        {
            get
            {
                return ChngMiddleNameTextbox.Text;
            }

            set
            {
                ChngMiddleNameTextbox.Text = value;
                this.Refresh();
            }
        }
        public object group
        {
            get
            {
                return GroupComboBox.SelectedItem;
            }
            set
            {
                foreach (var group in GroupComboBox.Items)
                {
                    if (group.Equals(value))
                    {
                        GroupComboBox.SelectedItem = group;
                        break;
                    }
                }
                this.Refresh();
            }
        }

        public DateTime birthday
        {
            get
            {
                return dateTimePicker.Value;
            }
            set
            {
                dateTimePicker.Value = value;
                this.Refresh();
            }
        }

        public bool gender
        {
            get
            {
                return MaleRadioButton.Checked;
            }
            set
            {
                if (value)
                {
                    MaleRadioButton.Checked = true;
                }
                else
                {
                    FemaleRadioButton.Checked = true;
                }
                this.Refresh();
            }
        }



        public event EventHandler? TryToChange;
        public event EventHandler? TryToDelete;
        public event EventHandler? OpenGroupAddForm;

        public void ClearComboBox()
        {
            GroupComboBox.Items.Clear();
            GroupComboBox.Refresh();
        }

        public void ClearFields()
        {
            ChngNameTextBox.Text = "";
            ChngNameTextBox.Refresh();
            ChngSurnameTextBox.Text = "";
            ChngSurnameTextBox.Refresh();
            ChngMiddleNameTextbox.Text = "";
            ChngMiddleNameTextbox.Refresh();
            MaleRadioButton.Checked = false;
            MaleRadioButton.Refresh();
            FemaleRadioButton.Checked = false;
            FemaleRadioButton.Refresh();
        }

        public void CloseForm()
        {
            this.Close();
        }
        public void SetData()
        {
            dateTimePicker.MaxDate = DateTime.Today;


        }
        public void InsertGroupComboBox(List<StudentGroup> group)
        {

            GroupComboBox.Items.Add(ADD_FUNCTION_STRING);
            foreach (var item in group)
            {

                GroupComboBox.Items.Add(item.Group);
            }
        }
        public void SelectGroupComboBox(StudentGroup group)
        {
            for (int i = 0; i < GroupComboBox.Items.Count; i++)
            {
                if (GroupComboBox.Items[i].ToString() == group.Group)
                {
                    GroupComboBox.SelectedIndex = i; break;
                }
            }

        }

        public void ShowForm()
        {
            this.ShowDialog();
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupComboBox.SelectedItem.ToString() == "-Добавить группу-")
            {
                if (OpenGroupAddForm != null) OpenGroupAddForm(this, EventArgs.Empty);
                GroupComboBox.ResetText();//TO DO(Постановка пустой строки)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TryToChange != null) TryToChange(this, EventArgs.Empty);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (TryToDelete != null) TryToDelete(this, EventArgs.Empty);
        }
    }

}
