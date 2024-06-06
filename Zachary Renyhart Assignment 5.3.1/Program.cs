namespace Zachary_Renyhart_Assignment_5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number of flower pots you would like to plant to see if its valid: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = { 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 };
            Console.WriteLine(Flowers(array , number ));



        }

        public static bool Flowers(int[] flower, int n)
        {
            int count = 0;
            for (int i = 0; i < flower.Length; i++)
            {
                if (flower[i] == 0 && (i == 0 || flower[i - 1] == 0) && (i == flower.Length -1 || flower[i + 1] == 0))
                {
                    flower[i++] = 1;
                    //This is incrementing how many times 1 is placed in the array
                    count++;
                }
                //If the amount of times a one can be implemented is greater or equal
                //to the amount the user inputted. This will display TRUE
                if (count >= n) return true;
            }
            return count >= n;
        }
    }
}
