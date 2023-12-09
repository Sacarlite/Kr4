namespace Kr4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            GroupListComboBox = new ComboBox();
            label1 = new Label();
            AddStudentButton = new Button();
            label2 = new Label();
            GenderComboBox = new ComboBox();
            SelectionButton = new Button();
            ResetButton = new Button();
            toolStrip1 = new ToolStrip();
            fileToolStripSplitButton = new ToolStripSplitButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripMenuItem2 = new ToolStripMenuItem();
            Id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            birthday = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, name, surname, dataGridViewTextBoxColumn1, Gender, birthday, Group });
            dataGridView1.Location = new Point(12, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(896, 518);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // GroupListComboBox
            // 
            GroupListComboBox.FormattingEnabled = true;
            GroupListComboBox.Items.AddRange(new object[] { "-" });
            GroupListComboBox.Location = new Point(429, 35);
            GroupListComboBox.Name = "GroupListComboBox";
            GroupListComboBox.Size = new Size(151, 28);
            GroupListComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 38);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Группа";
            // 
            // AddStudentButton
            // 
            AddStudentButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AddStudentButton.Location = new Point(578, 642);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(237, 41);
            AddStudentButton.TabIndex = 3;
            AddStudentButton.Text = "Добавить студента";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 73);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 4;
            label2.Text = "Пол";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "-", "Мужской", "Женский" });
            GenderComboBox.Location = new Point(429, 73);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(151, 28);
            GenderComboBox.TabIndex = 5;
            // 
            // SelectionButton
            // 
            SelectionButton.Location = new Point(605, 64);
            SelectionButton.Name = "SelectionButton";
            SelectionButton.Size = new Size(110, 29);
            SelectionButton.TabIndex = 6;
            SelectionButton.Text = "Выборка";
            SelectionButton.UseVisualStyleBackColor = true;
            SelectionButton.Click += SelectionButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(721, 64);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 7;
            ResetButton.Text = "Сброс";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripSplitButton, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(949, 27);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripSplitButton
            // 
            fileToolStripSplitButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripSplitButton.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            fileToolStripSplitButton.Image = (Image)resources.GetObject("fileToolStripSplitButton.Image");
            fileToolStripSplitButton.ImageTransparentColor = Color.Magenta;
            fileToolStripSplitButton.Name = "fileToolStripSplitButton";
            fileToolStripSplitButton.Size = new Size(64, 24);
            fileToolStripSplitButton.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(166, 26);
            toolStripMenuItem1.Text = "Сохранить";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(98, 24);
            toolStripDropDownButton1.Text = "Настройки";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem2.CheckOnClick = true;
            toolStripMenuItem2.CheckState = CheckState.Checked;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(237, 26);
            toolStripMenuItem2.Text = "Вывод приветстивия";
            toolStripMenuItem2.CheckStateChanged += toolStripMenuItem2_CheckStateChanged;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // name
            // 
            name.Frozen = true;
            name.HeaderText = "Имя";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // surname
            // 
            surname.HeaderText = "Фамилия";
            surname.MinimumWidth = 6;
            surname.Name = "surname";
            surname.ReadOnly = true;
            surname.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Отчество";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Гендер";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 125;
            // 
            // birthday
            // 
            birthday.HeaderText = "Дата Рождения";
            birthday.MinimumWidth = 6;
            birthday.Name = "birthday";
            birthday.ReadOnly = true;
            birthday.Width = 125;
            // 
            // Group
            // 
            Group.HeaderText = "Группа";
            Group.MinimumWidth = 6;
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 708);
            Controls.Add(toolStrip1);
            Controls.Add(ResetButton);
            Controls.Add(SelectionButton);
            Controls.Add(GenderComboBox);
            Controls.Add(label2);
            Controls.Add(AddStudentButton);
            Controls.Add(label1);
            Controls.Add(GroupListComboBox);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "База данных студентов";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox GroupListComboBox;
        private Label label1;
        private Button AddStudentButton;
        private Label label2;
        private ComboBox GenderComboBox;
        private Button SelectionButton;
        private Button ResetButton;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton fileToolStripSplitButton;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn birthday;
        private DataGridViewTextBoxColumn Group;
    }
}