using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                int[] ForwardArray = { 5, 6, 7 };
                Console.WriteLine("This is the forward array ");
                for (int i = 0; i < ForwardArray.Length; i++)
                {
                    Console.WriteLine($"{ForwardArray[i]}");
                }
                int[] ReverseArray = { 5, 6, 7 };
                for (int i = 0; i > ReverseArray.Length - i; i--)
                {
                    Console.WriteLine(ReverseArray[i]);
                }

                string[] Array = { "Ten", "Two", "Thirty" };
                         }
        }

    }
}
