namespace Zachary_Renyhart_Assignment_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter the X value to your problem: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the Y value of your problem so we can find the quadrant: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
          //This is all if statements
 
            
            if (num1 > 0 && num2 > 0)
            { 
                Console.WriteLine("Your coordinate points X and Y are in the first quadrant");
            }
            if (num1 < 0 && num2 > 0)
            {
                Console.WriteLine("Your coordinate points X and Y are in the second quadrant");
            }

            if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("Your coordinate points X and Y are in the third quadrant");
            }

            if (num1 > 0 && num2 < 0)
            {
                Console.WriteLine("Your coordinate points X and Y are in the fourth quadrant");
            }        

        }
    }
}
