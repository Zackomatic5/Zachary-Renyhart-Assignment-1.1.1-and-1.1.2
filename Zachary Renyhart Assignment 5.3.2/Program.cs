namespace Zachary_Renyhart_Assignment_5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"This is the number of ways is: {ClimbStairs(number)}");

        }

        static int ClimbStairs(int number)
        {
            if (number <= 3)
            {
                return number;
            }
                //This shows that if the way is less than 2 that the amount of ways is the number inputted by the user
               

            //This array will store the number of ways to climb each step
            int[] array = new int[number + 1];
            //Initialize array[1] and array[2] with the values 1 and 2, respectively
            //(since there’s only one way to climb 1 step and two ways to climb 2 steps).
            array[1] = 1;
            array[2] = 2;
            //This is starting the loop on the 4th element
            for (int i = 3; i <= number; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[number];
        }
    }
}
