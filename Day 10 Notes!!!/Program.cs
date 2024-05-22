using System.ComponentModel;

namespace Day_10_Notes___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multidimentional array
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            int rows = numbers.GetLength(0); //This gets the first array row
            int cols = numbers.GetLength(1); //this get the second array row

            for (int i = 0; i < rows; i++)
            {
                Console.Write(" | ");
                for (int j = 0; j < cols; j++)
                {

                    Console.Write(numbers[i, j] + " | "); //This adds the bracket to the array

                }
                Console.WriteLine(); //This makes it so the array goes 1 line down
            }

            int[,] array1 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            int[,] array2 = { { 5, 6, 7, 8 }, { 6, 7, 8, 9 } };

            int rows1 = array1.GetLength(0);
            int cols2 = array1.GetLength(1);
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(array1[i, j] + ", " + array2[i, j]);
                }
            }



            //This is #5 
            Console.WriteLine("Please enter a number 1-6");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int[] newArray = { 3, 6, 8, 7, 8 };
        }

        static void myMethod(int[] ints, int num1)
        {


        }
        
    }
}
