using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 2, 3, 5, 6 };
            Dictionary<int, int> count = new();
            foreach (int num in array) 
            {
                if (count.ContainsKey(num))
                {   //This checks to see if the dictionary already has the numbers in the array
                    break;
                }    
                else
                {
                    //If its not in the dictionary it adds a 1 value to it.
                    //The key is the number in the array. The value is 1 if its the first time it populates
                    count[num] = 1;
                }
                
            }           
            Console.WriteLine("duplicate numbers");                        
        }
       

    }
}
