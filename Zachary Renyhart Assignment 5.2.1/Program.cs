namespace Zachary_Renyhart_Assignment_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();
            //This splits the strings into words
            string[] Result = sentence.Split(' ');
            //This is showing that the array length of result is greater than 0
            if (Result.Length > 0)
            {
                Console.WriteLine($"The number of letters in the last word is: {Result[Result.Length - 1].Length}");
            }


        }
    }
}
