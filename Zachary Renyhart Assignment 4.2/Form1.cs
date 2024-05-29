namespace Zachary_Renyhart_Assignment_4._2
{
    public partial class Form1 : Form
    {

        Teacher teacher = new Teacher();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void LogOnButton_Click(object sender, EventArgs e)
        {
            teacher.TeacherUsername = "Teacher";
            teacher.TeacherPassword = "Admin";

            if (teacher.TeacherUsername == UserNameBox.Text && teacher.TeacherPassword == PasswordTextBox.Text)
            {

                //Instantiate the new form to show the screen
                Form3 studentForm = new Form3();
                studentForm.Show();
                                         
            }
            else
            {
                MessageBox.Show("You entered the wrong username or password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
