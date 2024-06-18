using System.Data;

namespace Zachary_Renyhart_Assignment_7._1._1
{
    internal class Program
    {

        // 7.1.1
        //You are a student who has recently taken an exam with your classmates.
        //However, the professor has not yet provided the students with a sorted list of exam scores.
        //To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm.
        //This way, you can obtain the sorted list of scores and see how you performed compared to your classmates.
        //Also, you choose selection sort since that is an easy way of implementation.
        static void Main(string[] args)
        {
            int[] array = { 36, 68, 23, 45, 89, 97, 77, 81, 65, 99, 58 };
            Console.Write("Your starting grades unsorted are: ");
            PrintArray(array);
            Console.Write("Your sorted grades are: ");
            ArrayMethod(array);


            //This is another way to do the selection sort starting at line 68!!
            SelectionSort(array);
            Console.Write("This is another way to do the selection sort: ");
            GeekPrintArray(array);
        }
         static void ArrayMethod(int[] array)
        {
           int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //This is starting at the second element and comparing every element to eachother
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        //If array[i] is greater than array[j] temp will equal array[i]
                        //And replace that element with array[j]
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        
                    }
                   
                }
            }
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

        }
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
               
            }
            Console.WriteLine();
        }





        //Below this is what the instructor showed us for this problem from geeks to geeks.
        static void GeekPrintArray(int[] arr)
        {   //n = length of the array!
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
        }

        static void SelectionSort(int[] arr)
        {
            //int n is the length of the array!
            int n = arr.Length;
            
                    //n-1 is the last element of the array.
            //Outer loop points to dividing line between the sorted and unsorted.
            for (int i = 0; i < n-1; i++)
            {
                //Find the minimum element in the unsorted portion
                int minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }                                        
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
                
            }
            Console.WriteLine();
        }
    }
}
