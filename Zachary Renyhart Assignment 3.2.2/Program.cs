namespace Zachary_Renyhart_Assignment_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3, } , { 4, 5, 6 } };
            int[,] numbers2 = { { 5, 6, 7 } , {  7, 8, 9 } };
            
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
               
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(" | ");
                    Console.Write(numbers[i, j] + numbers2[i, j]);//This is adding both arrays from above

                }
                Console.Write(" | ");
                Console.WriteLine();

            }

        }
    }
}
