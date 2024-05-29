namespace Zachary_Renyhart_Assignment_4._2
{
    partial class Form3
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
            StudentIDTextBox = new TextBox();
            StudentNameTextBox = new TextBox();
            StudentGPATextBox = new TextBox();
            AddStudentButton = new Button();
            SaveToFileButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 46);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "StudentID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 92);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 133);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "GPA";
            // 
            // StudentIDTextBox
            // 
            StudentIDTextBox.Location = new Point(141, 43);
            StudentIDTextBox.Name = "StudentIDTextBox";
            StudentIDTextBox.Size = new Size(266, 23);
            StudentIDTextBox.TabIndex = 3;
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(141, 89);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(266, 23);
            StudentNameTextBox.TabIndex = 4;
            // 
            // StudentGPATextBox
            // 
            StudentGPATextBox.Location = new Point(141, 130);
            StudentGPATextBox.Name = "StudentGPATextBox";
            StudentGPATextBox.Size = new Size(266, 23);
            StudentGPATextBox.TabIndex = 5;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(141, 159);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(123, 46);
            AddStudentButton.TabIndex = 6;
            AddStudentButton.Text = "Add Student";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // SaveToFileButton
            // 
            SaveToFileButton.Location = new Point(270, 159);
            SaveToFileButton.Name = "SaveToFileButton";
            SaveToFileButton.Size = new Size(137, 46);
            SaveToFileButton.TabIndex = 7;
            SaveToFileButton.Text = "Save to file";
            SaveToFileButton.UseVisualStyleBackColor = true;
            SaveToFileButton.Click += SaveToFileButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveToFileButton);
            Controls.Add(AddStudentButton);
            Controls.Add(StudentGPATextBox);
            Controls.Add(StudentNameTextBox);
            Controls.Add(StudentIDTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox StudentIDTextBox;
        private TextBox StudentNameTextBox;
        private TextBox StudentGPATextBox;
        private Button AddStudentButton;
        private Button SaveToFileButton;
    }
}