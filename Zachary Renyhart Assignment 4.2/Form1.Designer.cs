namespace Zachary_Renyhart_Assignment_4._2
{
    partial class Form1
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
            UserNameBox = new TextBox();
            PasswordTextBox = new TextBox();
            LogOnButton = new Button();
            Username = new Label();
            Password = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // UserNameBox
            // 
            UserNameBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameBox.Location = new Point(205, 142);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(286, 32);
            UserNameBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTextBox.Location = new Point(205, 180);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(286, 32);
            PasswordTextBox.TabIndex = 1;
            // 
            // LogOnButton
            // 
            LogOnButton.Location = new Point(262, 218);
            LogOnButton.Name = "LogOnButton";
            LogOnButton.Size = new Size(173, 50);
            LogOnButton.TabIndex = 2;
            LogOnButton.Text = "Log On";
            LogOnButton.UseVisualStyleBackColor = true;
            LogOnButton.Click += LogOnButton_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(112, 147);
            Username.Name = "Username";
            Username.Size = new Size(87, 21);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(117, 185);
            Password.Name = "Password";
            Password.Size = new Size(82, 21);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 375);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(140, 63);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(LogOnButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameBox;
        private TextBox PasswordTextBox;
        private Button LogOnButton;
        private Label Username;
        private Label Password;
        private Button ExitButton;
    }
}
