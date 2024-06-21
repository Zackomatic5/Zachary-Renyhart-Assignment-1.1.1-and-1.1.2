using System.Linq;
using System.Runtime.CompilerServices;

namespace Zachary_Renyhart_Assignment_7._2._3
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Please enter your first word");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Please enter your second word");
            string secondWord = Console.ReadLine();
            Console.WriteLine($" {secondWord} is an anagram of {firstWord} {IsAnagram(firstWord, secondWord)}"); // Output: true

        }

        static bool IsAnagram(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
                return false;

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char c in firstWord)
            {
                if (dictionary.ContainsKey(c))
                    //We iterate through each character in firstWord.
                    //If the character is already in the dictionary, we increment its count.
                    dictionary[c]++;
                else
                    dictionary[c] = 1;
            }

            foreach (char c in secondWord)
            {
                if (!dictionary.ContainsKey(c) || dictionary[c] == 0)
                    return false;
                //If the character is not in the dictionary (not a valid character
                //from firstWord) or its count in the dictionary is zero, we return false.
                //Otherwise, we decrement its count in the dictionary.

                dictionary[c]--;
            }

            return true;
        }
    }
}








/*Dictionary<string, int> dictionary = new();
Dictionary<string, int> dictionary2 = new();
static void Main(string[] args)
{


    Console.WriteLine("Please enter a word");
    string word1 = Console.ReadLine();
    int num = 0;
    int num2 = 0;
    MyMethod(word1, num);
    Console.WriteLine("Please enter another word to see if it is an anagram: ");
    string word2 = Console.ReadLine();
    Method2(word2, num2);
    IfAnadrome(word1, word2);

}












static void MyMethod(string word1, int num)
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

    }

}
static void Method2(string word2, int numbers)
{
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
}
static void IfAnadrome(string word1, string word2)
{
    if (word1.Equals(word2))
    {
        Console.WriteLine("Your word is an anadrome");
    }
    else
    {
        Console.WriteLine("Your word is not an anadrome");
    }
}
*/
