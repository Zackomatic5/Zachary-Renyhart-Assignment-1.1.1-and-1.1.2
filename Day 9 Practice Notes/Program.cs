using System.Net.Security;
using System.Text;

namespace Day_9_Practice_Notes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Hello, My name is zack");
            Console.WriteLine(builder);

            for (double num = 0; num < 150; num += 5)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine();
            Console.WriteLine("Hello, Please enter the date!: ");
            int output = Convert.ToInt32(Console.ReadLine());

            if (DateTime.IsLeapYear(output))
            {
                Console.WriteLine("It is a leap year!!");
            }
            else
            {
                Console.WriteLine("It is not a leap year!");
            }




            Console.WriteLine("Please input a string");
            string response = Console.ReadLine();
            Console.WriteLine("This is how many spaces are in your sentence " + myMethod);


            static int myMethod(string response)
            {
                int count = 0;
                foreach (char c in response)
                {
                    if (c == ' ')
                    {
                        count++;
                    }
                
                }
                return count;
            }
        }

        




        
    }
}
