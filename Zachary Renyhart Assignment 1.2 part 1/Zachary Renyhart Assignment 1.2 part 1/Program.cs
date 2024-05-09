namespace Zachary_Renyhart_Assignment_1._2_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readResult;
            do //This is telling below inside the curly brackets what to do.
            {
                Console.WriteLine("Please enter your choice from the menu");
                Console.WriteLine("Enter A for addition");
                Console.WriteLine("Enter S for subtraction");
                Console.WriteLine("Enter D for Divide");
                Console.WriteLine("Enter M for Multiply");
                Console.WriteLine("Enter X to exit to program");

                readResult = Console.ReadLine();

                switch (readResult)//This is a switch 
                {
                    case "A":
                    case "a":
                        AddMethod();//The switch allows the use of the method listed below
                    break;
                    case "S":
                    case "s":
                        SubtractMethod();
                    break;
                    case "D":
                    case "d":
                        DivideMethod();
                    break;
                    case "M":
                    case "m":
                        MultiplyMethod();
                    break;
                    case "x":
                    case "X":
                    break;
                       
                }
                
            }
            while ( readResult != "x" && readResult != "X" );
            //This allows the user to press X and leave the application 
            //This is the do and while function 

        }
        static void AddMethod()//This is the add method
        {
            Console.WriteLine("Please enter two integers");
            Console.WriteLine("Please enter integer 1:");
            int sum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter integer 2:");
            int sum2 = Convert.ToInt32(Console.ReadLine());
            int sum3 = sum1 + sum2;
            Console.WriteLine("Your answer is " + sum3);
            Console.WriteLine("Please enter another letter or press X and enter to exit");
        }
        static void SubtractMethod()//This is the subtract method
        {
            Console.WriteLine("Please enter two integers");
            Console.WriteLine("Please enter integer 1:");
            int sum4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter integer 2:");
            int sum5 = Convert.ToInt32(Console.ReadLine());
            int sum6 = sum4 - sum5;
            Console.WriteLine("Your answer is " + sum6);
            Console.WriteLine("Please enter another letter or press X and enter to exit");
        }
        static void MultiplyMethod() //This is the multiply method
        {
            Console.WriteLine("Please enter two integers");
            Console.WriteLine("Please enter integer 1:");
            int sum7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter integer 2:");
            int sum8 = Convert.ToInt32(Console.ReadLine());
            int sum9 = sum7 * sum8;
            Console.WriteLine("Your answer is " + sum9);
            Console.WriteLine("Please enter another letter or press X and enter to exit");
        }
        static void DivideMethod() //This is the divide method
        {
            Console.WriteLine("Please enter the highest interger first");
            Console.WriteLine("Please enter integer 1:");
            int sum10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter integer 2:");
            int sum11 = Convert.ToInt32(Console.ReadLine());
            int sum12 = sum10 / sum11;
            Console.WriteLine("Your answer is " + sum12);
            Console.WriteLine("Please enter another letter or press X and enter to exit");
        }
    }
}
    
    
