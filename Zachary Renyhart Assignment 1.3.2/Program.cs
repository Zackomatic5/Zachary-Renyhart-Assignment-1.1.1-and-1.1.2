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
            int length = numbers.Length; //This is converting the entire array length to the int of "length"
            int temp = 1;
            Console.WriteLine("This is displaying the array in order");
            foreach (int i in numbers) //This is displaying the entire array

            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < (length / 2); i++) //Below is changing the array to reverse
            {
                temp = numbers[i]; //This means temp = array #1 element,
                                   //
                                   //
                                   //This is grabbing the first number and making it temp
                numbers[i] = numbers[length - i - 1]; //This is assigning the last value to the first value
                numbers[length - i - 1] = temp;
               
            }
            Console.WriteLine("This is displaying the array in reverse");
            foreach (int i in numbers) //This is displaying the array after the for loop
            {
            
                Console.WriteLine(i);
            }
          
           
        }   


    }
}
