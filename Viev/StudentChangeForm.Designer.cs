namespace Kr4.Viev
{
    partial class StudentChangeForm
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
            ChngMiddleNameTextbox = new TextBox();
            ChngSurnameTextBox = new TextBox();
            ChngNameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GenderPanel = new Panel();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            label6 = new Label();
            GroupComboBox = new ComboBox();
            label7 = new Label();
            dateTimePicker = new DateTimePicker();
            button1 = new Button();
            deleteButton = new Button();
            GenderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Студент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // ChngMiddleNameTextbox
            // 
            ChngMiddleNameTextbox.Location = new Point(142, 122);
            ChngMiddleNameTextbox.Name = "ChngMiddleNameTextbox";
            ChngMiddleNameTextbox.Size = new Size(125, 27);
            ChngMiddleNameTextbox.TabIndex = 7;
            // 
            // ChngSurnameTextBox
            // 
            ChngSurnameTextBox.Location = new Point(142, 84);
            ChngSurnameTextBox.Name = "ChngSurnameTextBox";
            ChngSurnameTextBox.Size = new Size(125, 27);
            ChngSurnameTextBox.TabIndex = 8;
            // 
            // ChngNameTextBox
            // 
            ChngNameTextBox.Location = new Point(142, 47);
            ChngNameTextBox.Name = "ChngNameTextBox";
            ChngNameTextBox.Size = new Size(125, 27);
            ChngNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 10;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 129);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 11;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 166);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 12;
            label5.Text = "Пол";
            // 
            // GenderPanel
            // 
            GenderPanel.Controls.Add(FemaleRadioButton);
            GenderPanel.Controls.Add(MaleRadioButton);
            GenderPanel.Location = new Point(142, 155);
            GenderPanel.Name = "GenderPanel";
            GenderPanel.Size = new Size(242, 48);
            GenderPanel.TabIndex = 17;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 234);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 5;
            label6.Text = "Группа";
            // 
            // GroupComboBox
            // 
            GroupComboBox.FormattingEnabled = true;
            GroupComboBox.Location = new Point(142, 231);
            GroupComboBox.Name = "GroupComboBox";
            GroupComboBox.Size = new Size(151, 28);
            GroupComboBox.TabIndex = 18;
            GroupComboBox.SelectedIndexChanged += GroupComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 306);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 19;
            label7.Text = "Дата рождения";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(142, 301);
            dateTimePicker.MaxDate = new DateTime(2023, 5, 2, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 20;
            dateTimePicker.Value = new DateTime(2023, 4, 15, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(290, 381);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(34, 381);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 22;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // StudentChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 450);
            Controls.Add(deleteButton);
            Controls.Add(button1);
            Controls.Add(dateTimePicker);
            Controls.Add(label7);
            Controls.Add(GroupComboBox);
            Controls.Add(label6);
            Controls.Add(GenderPanel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ChngNameTextBox);
            Controls.Add(ChngSurnameTextBox);
            Controls.Add(ChngMiddleNameTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentChangeForm";
            Text = "StudentChangeForm";
            GenderPanel.ResumeLayout(false);
            GenderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ChngMiddleNameTextbox;
        private TextBox ChngSurnameTextBox;
        private TextBox ChngNameTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel GenderPanel;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private Label label6;
        private ComboBox GroupComboBox;
        private Label label7;
        private DateTimePicker dateTimePicker;
        private Button button1;
        private Button deleteButton;
    }
}