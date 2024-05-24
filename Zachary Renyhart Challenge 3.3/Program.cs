using System.ComponentModel.Design;

namespace Zachary_Renyhart_Challenge_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 0, 0, 0 };
            int target = 9;

            Console.WriteLine("Please enter a number");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a number");
            array[3] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                if (array[0] == target)
                {
                    Console.WriteLine("You have found a match");
                }
                else
                {
                    count = array[i]; 
                }   
                

                

                
                                                      
                


            }





        }
    }
}
