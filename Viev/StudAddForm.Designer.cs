namespace Kr4
{
    partial class StudAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            MiddleNameTextbox = new TextBox();
            GroupComboBox = new ComboBox();
            button1 = new Button();
            CloseButton = new Button();
            dateTimePicker = new DateTimePicker();
            GenderPanel = new Panel();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            GenderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 127);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 173);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "Пол";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 211);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Группа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 262);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 5;
            label6.Text = "Дата рождения";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(140, 32);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 6;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(140, 76);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(125, 27);
            SurnameTextBox.TabIndex = 7;
            // 
            // MiddleNameTextbox
            // 
            MiddleNameTextbox.Location = new Point(140, 124);
            MiddleNameTextbox.Name = "MiddleNameTextbox";
            MiddleNameTextbox.Size = new Size(125, 27);
            MiddleNameTextbox.TabIndex = 8;
            // 
            // GroupComboBox
            // 
            GroupComboBox.FormattingEnabled = true;
            GroupComboBox.Location = new Point(140, 208);
            GroupComboBox.Name = "GroupComboBox";
            GroupComboBox.Size = new Size(151, 28);
            GroupComboBox.TabIndex = 9;
            GroupComboBox.SelectedIndexChanged += GroupComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(274, 540);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(27, 540);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 14;
            CloseButton.Text = "Закрыть";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(140, 257);
            dateTimePicker.MaxDate = new DateTime(2023, 5, 6, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 15;
            dateTimePicker.Value = new DateTime(2023, 4, 15, 0, 0, 0, 0);
            // 
            // GenderPanel
            // 
            GenderPanel.Controls.Add(FemaleRadioButton);
            GenderPanel.Controls.Add(MaleRadioButton);
            GenderPanel.Location = new Point(126, 165);
            GenderPanel.Name = "GenderPanel";
            GenderPanel.Size = new Size(242, 39);
            GenderPanel.TabIndex = 16;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(134, 6);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(92, 24);
            FemaleRadioButton.TabIndex = 1;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Женский";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Location = new Point(14, 6);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(93, 24);
            MaleRadioButton.TabIndex = 0;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Мужской";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // StudAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 612);
            Controls.Add(GenderPanel);
            Controls.Add(dateTimePicker);
            Controls.Add(CloseButton);
            Controls.Add(button1);
            Controls.Add(GroupComboBox);
            Controls.Add(MiddleNameTextbox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudAddForm";
            Text = "Stud_add";
            FormClosing += StudAddForm_FormClosing;
            GenderPanel.ResumeLayout(false);
            GenderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private TextBox MiddleNameTextbox;
        private ComboBox GroupComboBox;
        private Button button1;
        private Button CloseButton;
        private DateTimePicker dateTimePicker;
        private Panel GenderPanel;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
    }
}