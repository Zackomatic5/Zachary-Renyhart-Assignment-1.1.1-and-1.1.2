namespace Zachary_Renyhart_Assignment_5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to see if it is palindrome: ");
            string word = Console.ReadLine();
            //This makes it so if this word is or isnt palindrome it will be displayed below
            if(isPalindrome(word))
            {
                Console.WriteLine($"{word} is palindrome");
            }
            else
            {
                Console.WriteLine($"{word} is not palindrome");
            }

        }


        public static bool isPalindrome(string word) 
        {
            if (word.Length <= 1 ) 
            {
                return true;
            }   //If the first element and the last element dont match this will be false
            if (word[0] != word[word.Length - 1])
            {
                return false;
            }
            else
            {   //This now checks that the [1] index and the second to last index match
                return isPalindrome(word.Substring(1, word.Length-2));
            }
            
            
        }
    }
}
