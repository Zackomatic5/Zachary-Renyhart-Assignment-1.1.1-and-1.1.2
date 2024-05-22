namespace Zachary_renyhart_Assignment_3._2._1
{
    internal class Program
    {


        static void Main(string[] args)
        {       //This is a multidimentional array
            int[,] numbers = { { 1, 3, 9, }, { 4, 6, 8 } };
            
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                Console.Write("| ");

                for (int j = 0; j < columns; j++)
                {
                    Console.Write(numbers[i, j] + " | ");//This adds the | everytime the loop goes around

                }               
                Console.WriteLine();

            }      





        }
    }
}
