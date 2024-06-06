namespace Zachary_Renyhart_Week_5_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 3, 3, 5, 5 };

            Dictionary<int, int[]> numbers = new Dictionary<int, int[]>();
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                numbers.Add(i, new int[] { array[i] });
                if (numbers.Count > 2)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }  
    }
}
