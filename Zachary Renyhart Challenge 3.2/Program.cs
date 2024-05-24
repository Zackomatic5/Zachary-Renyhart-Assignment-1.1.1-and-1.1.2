using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Challenge_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string containing both letters and numbers, I will return the sum of the numbers");
            string num = Console.ReadLine();
            double sum = 0;


            for (int i = 0; i < num.Length; i++)
            {
                    //select the character at the ith position
                    double number = char.GetNumericValue(num, i);
                    if (number != -1)
                    {
                    sum = sum + number;
                    }
                                                
            }
            Console.WriteLine($"The total of the numric digits is {sum}");
        }
    }
}
