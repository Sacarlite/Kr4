
using Kr4.Properties;

namespace Kr4
{
    public interface IMain
    {
        public int id { get; }
      
        public object selectectedGender { get; }
        public object selectectedGroup { get; }
        string? FilePath { get; }
        public void InsertGroupComboBox(List<StudentGroup> group);
        public void DataGridClear();
        void ComboboxClear();
        public void ResetSample();
        public void ShowForm();
        public void LoadDataTable(List<List<string?>> studentList);
        event EventHandler LoadData;
        event EventHandler Selection;
        event EventHandler Reset;
        event EventHandler SaveData;
        event EventHandler OpenForm;
        event EventHandler OpenChangeForm;
        event EventHandler ShowMainForm;
    }
    public partial class MainForm : Form, IMain
    {
        public int tmp_id;
        
        public void ShowForm()
        {
            Application.Run(this);
        }
        public object selectectedGroup
        {
            get
            {
                return GroupListComboBox.SelectedItem;
            }
        }

        public string? FilePath
        {
            get;
            private set;
        }

        public object selectectedGender
        {
            get
            {

                return GenderComboBox.SelectedItem;

            }
        }

        public int id
        {
            get
            {
                return tmp_id!;
            }
        }

    

        public MainForm()
        {
            InitializeComponent();
            GroupListComboBox.SelectedItem = "-";
            GenderComboBox.SelectedItem = "-";

        }

        public event EventHandler? LoadData;
        public event EventHandler? Selection;
        public event EventHandler? OpenForm;
        public event EventHandler? ShowMainForm;
        public event EventHandler? Reset;
        public event EventHandler? SaveData;
        public event EventHandler? OpenChangeForm;

        public void InsertGroupComboBox(List<StudentGroup> group)
        {
            GroupListComboBox.Refresh();
            GenderComboBox.Refresh();
            GroupListComboBox.SelectedItem = "-";
            GenderComboBox.SelectedItem = "-";
           
            foreach (var item in group)
            {
                GroupListComboBox.Items.Add(item.Group);
            }
        }

        public void LoadDataTable(List<List<string?>> studentList)
        {
            foreach (var student in studentList)
            {
                dataGridView1.Rows.Add(student.ToArray());
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GroupListComboBox.SelectedValue = 0;
            GenderComboBox.SelectedValue = 0;
            if (LoadData != null) LoadData(this, EventArgs.Empty);
            if (Settings.Default.Grettings)
            {
                toolStripMenuItem2.Checked = true;

            }
            else
            {
                toolStripMenuItem2.Checked = false;
            }
        }
        
        public void DataGridClear()
        {
            dataGridView1.Rows.Clear();
        }
        public void ComboboxClear()
        {
            dataGridView1.Rows.Clear();
            GroupListComboBox.Items.Clear();
            GroupListComboBox.Refresh();
            GroupListComboBox.Items.AddRange(new object[] { "-" });
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            if (Selection != null) Selection(this, EventArgs.Empty);
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (OpenForm != null) OpenForm(this, EventArgs.Empty);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (Reset != null) Reset(this, EventArgs.Empty);
        }

        public void ResetSample()
        {
            dataGridView1.Rows.Clear();
            GroupListComboBox.SelectedItem = "-";
            GenderComboBox.SelectedItem = "-";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? studId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tmp_id = Int32.Parse(studId);
            if (OpenChangeForm != null) OpenChangeForm(this, EventArgs.Empty);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.OverwritePrompt = true;
            dialog.Filter = "Xlsx|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
            }
            else
            {
                FilePath = "";
            }
            if (SaveData != null) SaveData(this, EventArgs.Empty);
        }

        private void toolStripMenuItem2_CheckStateChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem2.Checked)
            {
                Settings.Default.Grettings = true;
            }
            else
            {
                Settings.Default.Grettings = false;
            }
            Settings.Default.Save();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (ShowMainForm != null) ShowMainForm(this, EventArgs.Empty);
        }
    }
}
