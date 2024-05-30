using System.Data;

namespace Week_3_Weekend_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word: ");
            string palindrome = Console.ReadLine();
            myMethod(palindrome);


            static bool myMethod(string palindrome)
            {
                for (int i = 0; i < palindrome.length / 2; i++)
                  
                    if (palindrome[i] == palindrome[palindrome.length - i - 1)
                            {
        
                             }
                

           
            }
                else
            {
                return false;

            }

        }
    }
}
