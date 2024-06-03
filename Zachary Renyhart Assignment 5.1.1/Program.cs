using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Zachary_Renyhart_Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string word = Console.ReadLine();
            if (isPalindrome(word))
            {
                Console.WriteLine($"{word} Is a palindrome");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome");
            }
            
        } 
        static bool isPalindrome(string word)
        {
            for (int i = 0; i < word.Length /2; i++) 
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
            

            

        
    }
}
