using System.ComponentModel.Design;

namespace Zachary_Renyhart_Assignment_1._2_part_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter the first integer...");
            int sum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second integer...");
            int sum2 = Convert.ToInt32(Console.ReadLine());

            if (sum1 == sum2)
            {
                Console.WriteLine("These 2 numbers are equal");
            }
            else
            {
                Console.WriteLine("These 2 numbers are not equal!");
            }
        }
             
    }
}

