using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Assignment_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your year to figure out if it is a leap year or not! ");
           int year = Convert.ToInt32(Console.ReadLine());
            myMethod(year);





            static void myMethod(int year) //This is my method to figure out if it is a leap year
            {
                if (DateTime.IsLeapYear(year)) //If it is it will display yes
                {
                    Console.WriteLine("It is a leap year!!");
                }
                else
                {
                    Console.WriteLine("It is not a leap year!!");//If not it will say no
                }
            }
        }
    }
  
}
