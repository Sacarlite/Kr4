namespace Kr4
{
    partial class AddGroupForm
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
            AddGroupButton = new Button();
            ExitButton = new Button();
            GroupTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите название группы";
            // 
            // AddGroupButton
            // 
            AddGroupButton.Location = new Point(112, 107);
            AddGroupButton.Name = "AddGroupButton";
            AddGroupButton.Size = new Size(94, 29);
            AddGroupButton.TabIndex = 1;
            AddGroupButton.Text = "Добавить";
            AddGroupButton.UseVisualStyleBackColor = true;
            AddGroupButton.Click += AddGroupButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 107);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // GroupTextBox
            // 
            GroupTextBox.Location = new Point(48, 64);
            GroupTextBox.Name = "GroupTextBox";
            GroupTextBox.Size = new Size(125, 27);
            GroupTextBox.TabIndex = 3;
            // 
            // AddGroupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 172);
            Controls.Add(GroupTextBox);
            Controls.Add(ExitButton);
            Controls.Add(AddGroupButton);
            Controls.Add(label1);
            Name = "AddGroupForm";
            Text = "AddGroupForm";
            FormClosing += AddGroupForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddGroupButton;
        private Button ExitButton;
        private TextBox GroupTextBox;
    }
}