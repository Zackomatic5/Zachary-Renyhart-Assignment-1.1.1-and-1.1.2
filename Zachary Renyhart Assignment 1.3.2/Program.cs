using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int length = numbers.Length;
            int temp = 1;
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < (numbers.Length / 2); i++)
            {
                temp = numbers[i]; //This means temp = array #1
                numbers[i] = numbers[length - i - 1]; //This is assigning the last value to the first value
                numbers[length - i - 1] = temp;
               
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
           
           
        }   


    }
}
