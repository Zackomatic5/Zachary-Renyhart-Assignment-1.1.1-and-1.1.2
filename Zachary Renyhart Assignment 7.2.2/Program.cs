namespace Zachary_Renyhart_Assignment_7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                      
            string input = "amazon";
            Console.WriteLine($"This is your starting word: {input}");
            string output = ReverseVowels(input);
            Console.WriteLine($"This is your word with vowels reversed: {output}");

        }

        static string ReverseVowels(string input)
        {
            string output = "";

            int i = 0;
            int j = input.Length - 1; //This is the last element in the string.
            //While i is less than j. Because i is working from the front and j is working 
            
            //from the back. When they meet in the middle the while loop conditon is false.
            //This is turning input to an array of characters.
            char[] str1 = input.ToCharArray();

            while (i < j)
            {   //This will determine if the string input does NOT contain a vowel character!
                if (!IsVowel(str1[i]))
                {
                    i++;
                    continue;


                }//If J does not contain a vowel. This will go further backwards from the end of 
                //The string and continue until a vowel is met.
                if (!IsVowel(str1[j]))
                {
                    j--;
                    continue;
                }

                //Swap vowels
                char temp = str1[i];
                str1[i] = str1[j];
                str1[j] = temp;
                //Add this so we still test all the characters even if they meet the vowel requirements.
                i++;
                j--;
            }
            //Turning this back into a string and joining the strings together since its a char[].
            String str2 = String.Join("", str1);
                       
            return str2;
        }
        static Boolean IsVowel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }
    }
}
