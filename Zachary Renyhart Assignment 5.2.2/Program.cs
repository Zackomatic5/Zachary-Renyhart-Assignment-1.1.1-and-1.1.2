namespace Zachary_Renyhart_Assignment_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type in a number: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The natural numbers are:");
            NaturalNumbers(numbers, 1);
        }

        static void NaturalNumbers(int numbers, int amount)
        {   //This method will continue until #1
            if (amount <= numbers)
            {
                Console.Write(amount + " ");
                //This increments the amount of time the method goes around
                amount++;
                //This calls back the method and will continue to go until amount == numbers
                //Numbers will be what the user inputs, amount is 1.
                NaturalNumbers(numbers, amount);
            }
        }
    }
}
