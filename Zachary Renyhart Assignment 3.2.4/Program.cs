using System.Globalization;
using System.Numerics;

namespace Zachary_Renyhart_Assignment_3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] inputArray = {0, 0, 0, 0};

            Console.WriteLine("Enter first number: ");
            inputArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            inputArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            inputArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number: ");
            inputArray[3] = Convert.ToInt32(Console.ReadLine());

            double[] returnArray = TotalAverage(inputArray);
            Console.WriteLine($"The total is {returnArray[0]} and the average is {returnArray[1]}");
        }
        static double[] TotalAverage(double[] methodInput)
        {
            double total =  methodInput[0] + methodInput[1] + methodInput[2] + methodInput[3];
            double average = total / 4;
            double[] outputArray = {total, average}; //This is returning 2 different values which is why an array was created.
            return outputArray;

        }
    }
}
