namespace Day_4_Class_Notes_PC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers); //This is sorting an array
            foreach (int i in myNumbers) //This is a for each loop
            { //The example above can be read like this: for each string element (called i - as in index) in cars, print out the value of i.
                Console.WriteLine(i);
            }


            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" }; //This displays all the cars
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]); //I is displayed as INDEX (element)
            }
        }   
    }
}
