namespace Zachary_Renyhart_Assignment_4._1._1_New_Project__
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
            label1 = new Label();
            FNameTextBox = new TextBox();
            label2 = new Label();
            LNameTextBox = new TextBox();
            WorkPhoneTextBox = new TextBox();
            label3 = new Label();
            MobileNumberTextBox = new TextBox();
            label4 = new Label();
            AddressTextBox = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // FNameTextBox
            // 
            FNameTextBox.Location = new Point(109, 29);
            FNameTextBox.Name = "FNameTextBox";
            FNameTextBox.Size = new Size(176, 23);
            FNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // LNameTextBox
            // 
            LNameTextBox.Location = new Point(109, 58);
            LNameTextBox.Name = "LNameTextBox";
            LNameTextBox.Size = new Size(176, 23);
            LNameTextBox.TabIndex = 3;
            // 
            // WorkPhoneTextBox
            // 
            WorkPhoneTextBox.Location = new Point(109, 116);
            WorkPhoneTextBox.Name = "WorkPhoneTextBox";
            WorkPhoneTextBox.Size = new Size(176, 23);
            WorkPhoneTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Work Phone";
            // 
            // MobileNumberTextBox
            // 
            MobileNumberTextBox.Location = new Point(109, 87);
            MobileNumberTextBox.Name = "MobileNumberTextBox";
            MobileNumberTextBox.Size = new Size(176, 23);
            MobileNumberTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 90);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "Mobile Number";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(109, 145);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(176, 23);
            AddressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 148);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // button1
            // 
            button1.Location = new Point(139, 174);
            button1.Name = "button1";
            button1.Size = new Size(108, 28);
            button1.TabIndex = 10;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(AddressTextBox);
            Controls.Add(label5);
            Controls.Add(WorkPhoneTextBox);
            Controls.Add(label3);
            Controls.Add(MobileNumberTextBox);
            Controls.Add(label4);
            Controls.Add(LNameTextBox);
            Controls.Add(label2);
            Controls.Add(FNameTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FNameTextBox;
        private Label label2;
        private TextBox LNameTextBox;
        private TextBox WorkPhoneTextBox;
        private Label label3;
        private TextBox MobileNumberTextBox;
        private Label label4;
        private TextBox AddressTextBox;
        private Label label5;
        private Button button1;
    }
}
