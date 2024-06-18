using System.Linq;

namespace Zachary_Renyhart_Assignment_7._2._3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter a word");
            string word1 = Console.ReadLine();
            MyMethod(word1, 1, 1);

        }


        static void MyMethod(string word1, int num = 1, int numbers = 1)
        {
            
            Dictionary<string, int> dictionary = new();
            foreach (char letter in word1)
            {
                
                
                if (!dictionary.ContainsKey(Convert.ToString(letter)))
                {
                    num++;
                    
                }
                else
                {
                    dictionary.Add(Convert.ToString(letter), num);
                }
                Console.WriteLine("Please enter another word to see if it is an anagram: ");
                string word2 = Console.ReadLine();
                Dictionary<string, int> dictionary2 = new();
               
                foreach (char letters in word2)
                {


                    if (dictionary2.ContainsKey(Convert.ToString(letters)))
                    {
                        numbers++;
                    }
                    else
                    {
                        dictionary2.Add(Convert.ToString(letters), numbers);
                    }
                    
                }
                if (num == numbers)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }




            }



        }
    }
}
