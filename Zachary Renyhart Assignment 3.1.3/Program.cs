using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Assignment_3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input a sentence!: ");
            string input = Console.ReadLine();
            Console.WriteLine("You have this many spaces in this sentence: " + CountSpaces(input));
        }
        static int CountSpaces(string input) //This is a method to find the number of spaces in this sentence prompted above
        {
            int count = 0;
            foreach (char c in input) //Char finds the characters
            {
               if (c == ' ') //This makes c equal to spaces
                {
                    count++;
                }             
                
            }
            return count;
        }
    }   
}
