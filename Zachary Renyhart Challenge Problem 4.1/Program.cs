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
            double num = 0;
         switch (UnitUsed)
            {
                case > 199:
                    
                    MyMethodOne(num, UnitUsed);
                break;
            }          

        }
        static double MyMethodOne(double num, double unitUsed)
        {
            num = 1.20;
            double total = num * unitUsed;
            return total;
        }
    }    
   
}
