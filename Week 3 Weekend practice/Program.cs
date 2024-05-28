using System.Data;

namespace Week_3_Weekend_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = { { 1, 2, 3, 4, } , {5, 6, 7, 8 } };
            int rows = ints.GetLength(0);
            int cols = ints.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                Console.Write(" | ");
                

                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine(ints[i, j] + ints[i,j] + " | ");  
                    
                }
                Console.WriteLine();
            }


        }
    }
}
