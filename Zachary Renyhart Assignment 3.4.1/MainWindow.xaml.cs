using System.Numerics;
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


namespace Zachary_Renyhart_Assignment_3._4._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //This is creating a list from the class "Coffee"
        List<Coffee> CoffeeList = new List<Coffee>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Order_Button_Click(object sender, RoutedEventArgs e)
        {
            Coffee coffee = new Coffee();
                                    
            //You have to create a name of the textbox with x:Name=" ". The "this.IcedCoffee.Text" is the name of the textbox in XAML

            if (String.IsNullOrEmpty(this.IcedCoffee.Text)) //This is the name of the text box in XAML
            {
                MessageBox.Show("You must type (Yes or No) to declare if you want your coffee iced!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {   //coffee.Iced is the instantiated object from the class "Coffee"           
                coffee.Iced = this.IcedCoffee.Text;
            }


                                     //This is the name of the text box in XAML
            if (String.IsNullOrEmpty(this.HotCoffee.Text))
            {
                MessageBox.Show("You must type (Yes or No) to declare if you want your coffee hot", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                coffee.Hot = this.HotCoffee.Text;       
            }


                                    //This is the name of the textbox in XAML
            if (String.IsNullOrEmpty(this.Espresso.Text))
            {
                MessageBox.Show("Please type the number of Espresso's you would like", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                coffee.Espresso = Convert.ToInt32(this.Espresso.Text);
            }




            if (String.IsNullOrEmpty(this.Cappuccino.Text))
            {
                MessageBox.Show("Please type the number of Cappuccino's you would like", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                coffee.Cappuccino = Convert.ToInt32(this.Cappuccino.Text);
            }



            if (String.IsNullOrEmpty(this.Latte.Text))
            {
                MessageBox.Show("Please type the number of Latte's you would like", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                coffee.Latte = Convert.ToInt32(this.Latte.Text);
            }
            
            //This is adding all of the objects from the class "Coffee" and adding it to this list below. This will happen whenever the method is called out or used
            CoffeeList.Add(coffee);
        }
    }
}