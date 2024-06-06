using System.Linq;

namespace Zachary_Renyhart_Week_5_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 3, 5, 2 };
           
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            
            //The first 5 will skip the if statement and go to the else statement because it is not in the dictionary.
            foreach (int num in array)
            {   //num is the key, count is the value
                
                //if the dictionary already has the "Key" then it will add 1
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;   
                }
                else
                {   //The value of the dictionary is 1.
                    numbers.Add(num, 1);                   
                }
                
            }//The numbers.keys is going through and gets a collection of the keys
              foreach (int element in numbers.Keys)
            {   //If the element of the array is only shown once it will show below
                if (numbers[element] == 1)
                {
                    Console.WriteLine(element);
                }
            }
        
      


        }
      
    }
}
