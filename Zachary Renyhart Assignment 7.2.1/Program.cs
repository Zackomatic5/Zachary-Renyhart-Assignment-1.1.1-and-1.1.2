namespace Zachary_Renyhart_Assignment_7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 8, 2, 7, 9, 1, 5, 4 };
            ShellSort(array);
            PrintArray(array);


        }
        static void ShellSort(int[] array)
        {
            int length = array.Length;
            //Num is the length of the array / 2

            for (int num = length / 2; num > 0; num /= 2)
            {//Starts with a gap (num) equal to half the array length and reduces it by half in each iteration.
                for (int i = num; i < length; i++)
                //Starts from the gap index and goes up to the end of the array.
                {
                    int j;
                    int temp = array[i]; //If the element at array[j - num] is greater than temp, shift it to the right.
                    for (j = i; j >= num && array[j - num] > temp; j -= num)
                    {//Compares adjacent elements within the gap: ^^
                        array[j] = array[j - num];
                        
                    }
                    array[j] = temp;
                }
            }
        }
        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        } 
    }
}
