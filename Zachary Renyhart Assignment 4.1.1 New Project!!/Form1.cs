namespace Zachary_Renyhart_Assignment_4._1._1_New_Project__
{
    public partial class Form1 : Form
    {
        //This dictionary is linking the information for the string used!!
        //This is instantiating the dictionary class to the object ContactBook            
        Dictionary<string, Person> contactBook = new Dictionary<string, Person>();
        //This is creating a contact book dictionary list.

        public Form1()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //This is calling out the specific text box
            Person newPerson = new Person();

            //This is taking the input from the user and storing it as the property "First Name"
            newPerson.FirstName = FNameTextBox.Text; 
            newPerson.LastName = FNameTextBox.Text;
            newPerson.MobileNumber = MobileNumberTextBox.Text;
            newPerson.WorkPhone = WorkPhoneTextBox.Text;
            newPerson.Address = AddressTextBox.Text;
            
            //This is creating the key for the dictionary
            string fullName = FNameTextBox.Text + LNameTextBox.Text;
            //Fullname is the string and newPerson is the value!!
            contactBook.Add(fullName, newPerson);
        }
    }
}
  