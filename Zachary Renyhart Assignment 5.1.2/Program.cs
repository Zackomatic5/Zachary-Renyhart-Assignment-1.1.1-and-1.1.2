namespace Zachary_Renyhart_Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is recursive code!!!

            Console.WriteLine("Please enter a number");

            string number = Console.ReadLine();
          int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {   //This is converting every index to a integer. Because originally they are a char.             
                sum += Convert.ToInt32(Convert.ToString(number[i]));
                //+= is adding and equaling every integer typed.
            }
            Console.WriteLine($"Your total is: {sum}");


        }
        
    }
}
