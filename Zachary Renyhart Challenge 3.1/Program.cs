namespace Zachary_Renyhart_Challenge_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check if it is a palindrome!: ");
            string word = Console.ReadLine();
            
            if(TestPalindrome(word))
            {
                Console.WriteLine($"{word} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome.");
            }

        }



        static bool TestPalindrome(string word)
        {
            bool isPalindrome = false;
            for (int i = 0; i < word.Length / 2; i++)
            {  //This is showing the first letter is the same as the last 
               //the length of the string
                if (!(word[i] == word[word.Length - 1 - i]))
                {
                    return false;                    
                }
             
            }
            return true;

        }
    }
}
