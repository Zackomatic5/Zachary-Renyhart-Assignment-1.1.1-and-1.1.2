using System.ComponentModel.Design;

namespace Zachary_Renyhart_Assignment_3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 6, 2 };
            Console.WriteLine("Pick a number 1-6");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MyMethod(myArray, num1));
                                 
        }
        static int MyMethod(int[] methodArray, int num1)//This method can have any variables
        {
            for (int i = 0; i < methodArray.Length; i++)
            {
                if (num1 == methodArray[i])
                {
                   return i;//This returns the index if the input from the user is true

                }

            }
            return -1;
        } 
    }
}
