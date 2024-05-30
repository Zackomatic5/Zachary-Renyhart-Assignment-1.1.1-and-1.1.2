using System.Runtime.ConstrainedExecution;

namespace Zachary_Renyhart_Challenge_Problem_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter your customer ID #: ");
            int customerID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your name");
            string customerName = Console.ReadLine();
            Console.WriteLine("Hello " + customerName + "," + " please enter the unit amount you consumed: ");
            double UnitUsed = Convert.ToDouble(Console.ReadLine());

            switch (UnitUsed)
            {
                case <= 199:
                    double num = 1.20;
                    Console.WriteLine($"Amount Charges @ $1.20 a unit are $ {MyMethodOne(num, UnitUsed)}");
                    Console.WriteLine();
                    break;

                case <= 399:
                    double num2 = 1.50;
                    Console.WriteLine($"Amount charges @ $1.50 a unit are $ {MyMethodTwo(num2, UnitUsed)}");
                    Console.WriteLine();
                break;

                case <= 599:
                    double num3 = 1.80;
                    Console.WriteLine($"Amount charges @ $1.80 a unit are $ {MyMethodThree(num3, UnitUsed)}");
                    Console.WriteLine();
                break;

                case > 600:
                    double num4 = 2.00;
                    Console.WriteLine($"Amount charges @ $2.00 a unit are $ {MyMethodTwo(num4, UnitUsed)}");
                    Console.WriteLine();
                break;


            }          

        }
        static double MyMethodOne(double num, double unitUsed)
        {
            Console.WriteLine($"Your unit used was {unitUsed}");
            num = 1.20;
            double total = num * unitUsed;
            return total;
        }
        static double MyMethodTwo(double num, double unitUsed)
        {
            num = 1.50;
            double total = num * unitUsed;
            if (total > 400)
            {
                Console.WriteLine($"Your unit used was: {unitUsed}");
                Console.WriteLine($"Your initial charge $ {total}");
                double percentage = 0.15;
                double grandTotal = total * percentage;
                total = total + grandTotal;
                
                Console.WriteLine($"Your surcharge was $ {grandTotal}");
               
            }
            return total;
        }

        static double MyMethodThree(double num, double unitUsed)
        {
            num = 1.80;
            double total = num * unitUsed;
            if (total > 400)
            {
                Console.WriteLine($"Your unit used was: {unitUsed}");
                Console.WriteLine($"Your initial charge $ {total}");
                double percentage = 0.15;
                double grandTotal = total * percentage;
                total = total + grandTotal;

                Console.WriteLine($"Your surcharge was $ {grandTotal}");

            }
            return total;
        }

        static double MyMethodFour(double num, double unitUsed)
        {
            num = 2.00;
            double total = num * unitUsed;
            if (total > 400)
            {
                Console.WriteLine($"Your unit used was: {unitUsed}");
                Console.WriteLine($"Your initial charge $ {total}");
                double percentage = 0.15;
                double grandTotal = total * percentage;
                total = total + grandTotal;

                Console.WriteLine($"Your surcharge was $ {grandTotal}");

            }
            return total;
        }
    }    
   
}
