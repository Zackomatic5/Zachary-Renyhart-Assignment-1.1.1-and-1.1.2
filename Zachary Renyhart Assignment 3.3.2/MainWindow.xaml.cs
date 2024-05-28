using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zachary_Renyhart_Assignment_3._3._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //This is instantiating the list for "Student" creating a StudentList list
        List<Student> StudentList = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
           
            
        }
        //When we click the add student button is runs this method
        private void addStudent_Click(object sender, RoutedEventArgs e)//This is a event handler
        {   //This is instantiating the class "Student" and making the object of "student"
            var student = new Student();


            //Check the user has provided a student ID
            if (String.IsNullOrEmpty(this.studentId.Text))
            {                   // The .studentId is what is displayed in XAML!!
                MessageBox.Show("The student must have a Student ID", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {   //If the text is not null or empty, we will assign it to the specific property
                student.StudentID = Convert.ToInt32(this.studentId.Text);
            }



            //This is for the first name
            if (String.IsNullOrEmpty(this.firstName.Text))
            {
                MessageBox.Show("The student must have a First Name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {   //This is storing the first name if the student types in something
                student.FirstName = this.firstName.Text;
            }



            //This is for the last name
            if (String.IsNullOrEmpty(this.lastName.Text))
            {
                MessageBox.Show("The student must have a Last Name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {   //This is storing the last name if the student types in something
                student.LastName = this.lastName.Text;
            }



            //This is for the address
            if (String.IsNullOrEmpty(this.address.Text))
            {
                MessageBox.Show("The student must have a Address", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {   //This is storing the address if the student types in something
                student.Address = this.address.Text;
            }




            if (String.IsNullOrEmpty(this.monthOfAdmission.Text))
            {
                MessageBox.Show("The student must have a valid Month Of Admission", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.MonthOfAdmission = this.monthOfAdmission.Text;
            }




            if (String.IsNullOrEmpty(this.gpa.Text))
            {
                MessageBox.Show("The student must have a GPA", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.GPA = Convert.ToDouble(this.gpa.Text);
            }

            //This is adding the "student" we just created to the list
            StudentList.Add(student);

        }




        static void DeleteStudent() //This is a event handler
        {


        }

        
    }

    
}