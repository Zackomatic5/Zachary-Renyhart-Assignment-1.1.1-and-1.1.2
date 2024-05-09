using System.Runtime.InteropServices;

namespace Zachary_Renyhart_Assignment_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(); //This is the constructor and Point() is a method
            Point point2 = new Point();

            if (point1.x == point2.x)
            {
                Console.WriteLine("Points are on the same axis");
            }
            else
            {
              Console.WriteLine("Points are not on the same axis");   
            }
          

        } //The world public is a access
        public struct Point //Structure named point with 2 properties X and Y
        { //Custom data type
           public double x;
           public double y;

        }
    }
}
