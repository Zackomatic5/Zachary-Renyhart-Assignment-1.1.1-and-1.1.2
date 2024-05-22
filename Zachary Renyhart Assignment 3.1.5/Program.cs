namespace Zachary_Renyhart_Assignment_3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 2, 3, 1, 1, 8, 4, 7 };
            FindNumbers(myArray);
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
            
            static void FindNumbers(int[] myArray ) //This is finding the first duplicate 1 in the array
            {

                for (int i = 0; i < myArray.Length + 1; i++)
                {
                    if (myArray[i] == myArray[i + 1])
                    {
                        myArray[i] = 0;
                        myArray[i + 1] = 0;
                        Console.WriteLine(myArray);
                        break; //This breaks you out of the loop
                    }
                }
            }          

        }
    }
    
}
