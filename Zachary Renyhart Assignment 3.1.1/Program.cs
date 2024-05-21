using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Zachary_Renyhart_Assignment_3._1._1
{
    internal class Program
    {




        static void Main(string[] args)
        {
            //This is the string builder class
            StringBuilder builder = new StringBuilder("Hello, Today we will be displaying only even numbers from 2-100");
            Console.WriteLine(builder);

            for (int i = 2; i <= 100; i += 2) //This is counting by increments of 2.
            {
                Console.WriteLine(i);
            }


        }

           

        
    }       


    
}
