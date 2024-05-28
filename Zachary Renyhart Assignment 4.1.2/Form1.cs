namespace Zachary_Renyhart_Assignment_4._1._2
{
    //This is using the ICalculator interface
    public partial class Form1 : Form, ICalculator
    {

        double firstNumber = 0;
        //This will keep track of the operation
        string operation = ""; //This is a null string

        public Form1()
        {
            InitializeComponent();
        }
        //These are all the methods described in the interface tab "ICalculator"
        public void AddMethod()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = "+";
        }
        public void SubtractMethod()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = "-";
        }
        public void MultiplyMethod()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = "*";
        }
        public void DivideMethod()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = "/";
        }



        private void OneButton_Click(object sender, EventArgs e)
        {
            //If it is 0 when you press 1 itll add 1.
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "1";
            }
            else
            {   //If the text isnt 0 it will add 1
                ResultTextBox.Text = ResultTextBox.Text + "1";
            }

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            //If it is 0 when you press 2 itll add 2 etc...
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "2";
            }
            else
            {   //If the text isnt 0 it will add 2 etc...
                ResultTextBox.Text = ResultTextBox.Text + "2";
            }

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "3";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "3";
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "4";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "5";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "6";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "7";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "7";
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "8";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "9";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "9";
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "0";
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = ".";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + ".";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {            //This will clear the numbers back to "0"
            ResultTextBox.Text = "0";

        }

        //This is calling out all the methods above that we created!!
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddMethod();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            SubtractMethod();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            MultiplyMethod();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            DivideMethod();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {

                case "+":
                    double addNumber = Convert.ToDouble(ResultTextBox.Text);
                    double addTotal = firstNumber + addNumber;
                    ResultTextBox.Text = Convert.ToString(addTotal);                    
                break;
                    


                case "-":
                double minusNumber = Convert.ToDouble(ResultTextBox.Text);
                double minusTotal = firstNumber - minusNumber;
                ResultTextBox.Text = Convert.ToString(minusTotal);
                break;


                case "*":
                double multiplyNumber = Convert.ToDouble(ResultTextBox.Text);
                double multiplyTotal = firstNumber * multiplyNumber;
                ResultTextBox.Text = Convert.ToString(multiplyTotal);
                break;


                case "/":
                double divideNumber = Convert.ToDouble(ResultTextBox.Text);
                    if (divideNumber == 0 || firstNumber == 0)             
                    {
                        ResultTextBox.Text = Convert.ToString("You cannot divide by 0");
                    }                   
                double divideTotal = firstNumber / divideNumber;
                ResultTextBox.Text = Convert.ToString(divideTotal);
                break;
            }
        }
    }
}
