using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zachary_Renyhart_Assignment_4._2
{
    public partial class Form3 : Form
    {   //Instantiate a newstudent object
        Student newStudent = new Student();

        public Form3()
        {
            InitializeComponent();
        }
        //This is on the form 3 design
        //When you click on the add student button it checks if you typed in something in the text box
        public void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentIDTextBox.Text != "") //If the text box does not equal a null string
            {
                //Instantiating the student class and assigning the text box values
                newStudent.StudentID = StudentIDTextBox.Text;
                

            }
            else
            {
                MessageBox.Show("Please enter the Student's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (StudentNameTextBox.Text != "")
            {
                newStudent.StudentName = StudentNameTextBox.Text;
                
            }
            else
            {
                MessageBox.Show("Please enter the Student's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (StudentGPATextBox.Text != "")
            {
                newStudent.GPA = Convert.ToDouble(StudentGPATextBox.Text);
                
            }
            else
            {
                MessageBox.Show("Please enter the Student's GPA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //This is adding a "newStudent" to the list "StudentList" instantiated above
            //Program has to be put to use it from the program.cs file
            Program.StudentList.Add(newStudent);
        }
               
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {

                //StreamWriter writer = new StreamWriter("C:\\Visual Studio\\Assignment4.2.2.txt");                
            StreamWriter writer = new StreamWriter("C:\\Visual Studio\\Assignment4.2.3.txt");
            writer.WriteLine(Program.StudentList[0].GPA);
            writer.Close();
            
            
        }
    }
}
    