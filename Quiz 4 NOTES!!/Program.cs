namespace Quiz_4_NOTES__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anything 8.5 and below goes to 8. 8.6 or higher goes to 9!
            //This rounds to the closest EVEN number, Only for the MIDPOINT
            Console.WriteLine(Math.Round(8.5));
            //This will always round up regardless of the decimal.
            Console.WriteLine(Math.Ceiling(4.1)); // 4.1 = 5


            //Create me a new array with 0 integers
            int[] num = new int[0];
            //This is saying to display the first element of the array "Num"
            Console.WriteLine(num[0]);


            string a = "TechBeamers";
            //Capitalized version goes after lower case
            string b = "TECHBEAMERS";
            int c;
            c = a.CompareTo(b);
            Console.WriteLine(c);


        }
    }
}
