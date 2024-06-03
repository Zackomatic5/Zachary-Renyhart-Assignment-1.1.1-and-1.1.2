using System.ComponentModel.Design;
using System.Security.Authentication;

namespace Zachary_Renyhart_Challenge_Problem_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the characters [, {, ( to see if they are in the correct order");
            string input = Console.ReadLine();
            
            
            Dictionary<char, char> output = new Dictionary<char, char>();
            output.Add('(', ')'); //This is adding these properties to the dictionary
            output.Add('{', '}');
            output.Add('[', ']');
            foreach (char c in input)
            {
                if (input.Contains(c))
                {
                    input = input.Remove(c);
                   
                }
                if (i == { && i + 1 == }    
               
            }



        }
           


        

      
    }
}
