using System.Globalization;

namespace Day_16_Class_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0; //This is declaring the variable of age with a undefined variable        
            string name = "";
            bool? married = null;
            Console.WriteLine($"This is your age: {age}");





            //This is recursive code!!!

            Console.WriteLine("Please enter a number");

            int number = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine("factorial of" + number + "=" + factorial.ToString());



            Console.WriteLine("Please enter a name");
            string lastWord = Console.ReadLine();
            MyName(lastWord);



            Console.WriteLine("Please enter a number");
            int sum1 = Convert.ToInt32(Console.ReadLine());
            //The 1 is the amount for the 2nd variable in the method
            ReverseNumbers(sum1, 1);
            Console.WriteLine();
            Console.WriteLine("This is reversing the numbers");
            Numbers(sum1, 1);
            Console.WriteLine();
            Console.WriteLine("This is adding the numbers");
        }
        public static double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);//Recursive call
            //Recrusive calls itself
        }

        public static void MyName(string lastWord)
        {   
            string[] strings = lastWord.Split(' ');
            if (strings.Length > 0)
                Console.WriteLine($"The length of your last word is {strings[strings.Length - 1].Length}"); ;

        }

        //For both of these, this is doing a loop while calling a method
        public static void ReverseNumbers(int length, int amount) 
        {
            
            if (length >= amount)
            {
                Console.Write($"{length} ");
                length--;
                ReverseNumbers(length, amount);
            }

        }

        //This is overloading paramaters 
        public static void Numbers(int length, int amount)
        {   //For a reverse we want to keep the numbers the same
            if (amount <= length) 
            {
                Console.Write($"{amount} ");
                amount++;
                Numbers(length, amount);
            }
        }
    }
}
