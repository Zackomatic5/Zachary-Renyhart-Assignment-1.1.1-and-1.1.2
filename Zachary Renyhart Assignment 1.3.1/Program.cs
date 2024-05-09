namespace Zachary_Renyhart_Assignment_1._3._1
{
    internal class Program
    {
        static void Main(string[] args)

        { string outPut;
            do
            {
                Console.WriteLine("Hello and welcome to my application, Please choose the following characters below!");
                Console.WriteLine();
                Console.WriteLine("Please enter T for the area of a triangle");
                Console.WriteLine("Please enter S for the area of a square");
                Console.WriteLine("Please enter R for the area of a rectangle");
                Console.WriteLine();
                Console.WriteLine("Please enter X to exit the application");

                outPut = Console.ReadLine();
                switch (outPut) //This is reading the output from the user
                {
                    case "t":
                    case "T":
                        Console.WriteLine("You want to find the area of a triangle"); //This is if the user selects "T" or "t"
                        Console.WriteLine("Please enter the base");
                        double Base = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the height");
                        double Height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(TriangleMethod(Base, Height));                       
                        break;

                    case "S":
                    case "s":                   
                        Console.WriteLine("You want to find the area of a square"); //This is if the user selects "S" or "s"
                        Console.WriteLine("Please enter the Length");
                        double side = Convert.ToDouble(Console.ReadLine());                     
                        Console.WriteLine(SquareMethod(side));                      
                        break;

                    case "R":
                    case "r":
                        Console.WriteLine("You want to find the area of a rectangle"); //This is if the user selects "R" or "r"
                        Console.WriteLine("Please enter the Length");
                        double Length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the Width");
                        double Width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(RectangleMethod(Length, Width));
                        break;

                    default: //This states that any letter other than the ones clarified above with default to the line of code "Invalid Statement"
                        Console.WriteLine("Invalid Statement, Please enter the correct letter");
                        break;

                }


            }
            while (outPut != "x" && outPut != "X"); //This states if the user selects "x" or "X" they will close the application
            {


            }
            static double TriangleMethod(double Base, double Height) //This is the triangle method
            {
               
                return (Base * Height) / 2;       //This is returning the value we want for our method    
               //While in C# you must put parenthesis when doing divison because of PEMDAS
            }
            static double SquareMethod(double side) //This is the square method
            {
                return side * side;
            }
            static double RectangleMethod(double Length, double Width) //This is the rectangle method
            {
               return Length * Width;
            }
           
        }
    }
}
