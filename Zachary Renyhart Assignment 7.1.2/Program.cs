using System.Text;

namespace Zachary_Renyhart_Assignment_7._1._2
{
    internal class Program
    {

        // You are given two strings word1 and word2.
        // Merge the strings by adding letters in alternating order,
        // starting with word1. If a string is longer than the other,
        // append the additional letters onto the end of the merged string.
        //Return the merged string.
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a word: ");
            string word1 =  Console.ReadLine();
            Console.WriteLine("Please type in another word to have these 2 words merge: ");
            string word2 =  Console.ReadLine();
            
            Console.Write("This is the word merged together: ");
            Arraymethod(word1, word2);
            
        }

        static void Arraymethod(string word1, string word2)
        {
            int num1 = word1.Length;
            int num2 = word2.Length;
            int lengthOfWords = num1 + num2;
            //Determines the maximum length between word1 and word2.
            

            StringBuilder mergeWords = new();
            //used to build strings by appending characters.
            for (int i = 0; i < lengthOfWords; i++)
            {
                if (i < word1.Length)
                {//If i is less than the length of word1,
                 //it appends the i-th character of word1 to MergeWords.
                    mergeWords.Append(word1[i]);
                }
                if (i < word2.Length)
                {//If i is less than the length of word2,
                 //it appends the i-th character of word2 to MergeWords.
                    mergeWords.Append(word2[i]);
                }

            }// Converts the MergeWords StringBuilder to a regular string
             // and prints it to the console.
            Console.Write(mergeWords.ToString());

        }
    }
}
