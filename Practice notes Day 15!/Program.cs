namespace Practice_notes_Day_15_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter a number");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the width");
            //    int width = Convert.ToInt32(Console.ReadLine());
            //    int[] widthArray = new int[width];

            //    for (int a = 0; a < widthArray.Length; a++)
            //    {
            //        widthArray[a] = num;

            //    }
            //        for (int i = widthArray.Length-1; i >= 0; i--)
            //        {
            //            for (int j = 0; j <= i; j++)
            //            {
            //                Console.Write(widthArray[j]);


            //            }
            //            Console.WriteLine();
            //        }   i

            int[,] array = { { 1, 2 }, { 3, 4 } };
            int[,] array2 = { { 5, 6 }, { 7, 8 } };
            int[,] array3 = new int[2, 2]; //This is setting up 2 colums and 2 rows

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                { //This is adding the arrays 
                    array3[i, j] = array[i, j] + array2[i, j];
                    
                }
                Console.WriteLine("");
            } 
            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0;j < cols; j++)
                {
                    Console.Write(array[i, j] + " | "); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array2[i, j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array3[i, j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] resultArray = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {

                        return resultArray = [i, j];
                    }
                }
            }
            return resultArray;
        }





    }
}
