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

            


            //This is using a dictionary and finding the letter that only occurs once.
            string[] array = { "a", "b", "a", "c", "c" };
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string letter in array)
            {   //If the dictionary contains the letter already this will add 1 to it.
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter]++;
                }
                else
                {   //The value of the dictionary is 1. The key is the Letter in the array.
                    dictionary.Add(letter, 1);
                }
            }   //If the value of the key is 1 then this will display the key.
            foreach (string num in dictionary.Keys)
            {   //If the element of the array is only shown once it will show below
                if (dictionary[num] == 1)
                {
                    Console.WriteLine($"This element only has one value {num}");
                }
            }
            


            int[] arrays = { 1, 2, 4, 5, 6, 7 };
            HashSet<int> nums = new HashSet<int>();
            //A Hashset holds one unique value instead of a dictionary which is a Key, Value.
            //A Hashset is like a dictionary but it holds only one value when a dictionary holds a key and a value
            foreach (int index in arrays)
            {
                //This is adding every number to the Hashset
                nums.Add(index);
            }
            for (int i = 1; i < array.Length; i++)
            {   //If the dictionary does not contain the index of the forloop. I will display the missing number
                if (!nums.Contains(i))
                {
                    Console.WriteLine($"The number that is missing is: {i}");
                }
            }
        }




        //This is a recursive method
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
            {   //This will keep displaying until the if statement is 1 == 1.
                Console.Write($"{length} ");
                length--;
                ReverseNumbers(length, amount);
            }

        }

        //This is overloading paramaters 
        public static void Numbers(int length, int amount)
        {   //For a reverse we want to keep the numbers the same
            if (amount <= length)
            {  //This will keep displaying until the if statement is 1 == 1.
                Console.Write($"{amount} ");
                amount++;
                //This is calling back the method and will continue until the if statement is 1 == 1.
                Numbers(length, amount);
            }
        }

        
    }
}
