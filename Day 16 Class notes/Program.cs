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
    }
}
