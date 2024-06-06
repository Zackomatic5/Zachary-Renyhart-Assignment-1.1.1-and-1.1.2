namespace Zachary_Renyhart_Assignment_5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type in a number: ");
            int numbers = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Reverse natural numbers are: ");
            ReverseNumbers(numbers, 1);
        }

        static void ReverseNumbers(int numbers, int amount)
        {
            if (numbers >= amount)
            {
                Console.Write(numbers  + " ");
                //This method will continue until numbers == 1
                numbers--;
                //This calls back the method and will continue to go until amount == numbers
                //Numbers below will always be what the user inputs
                ReverseNumbers(numbers, amount);
            }
        }
    }
}
