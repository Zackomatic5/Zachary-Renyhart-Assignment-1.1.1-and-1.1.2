namespace Zachary_Renyhart_Assignment_8._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 10, 8, 9, 5, 1 };
            int length = arr.Length;
            QuickSortMethod(arr, 0, length - 1);
            Console.Write("This is the sorted array: ");
            //This is displaying the array
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }

        static void SwapElements(int[] arr, int i, int j) 
        {
           //This is a method for swapping the elements
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int PartitionElements(int[] arr, int low, int high)
        {
            //This is choosing the pivot point
            int pivot = arr[high];

            //The right position of the pivot found so far and the index of the smaller element
            int i = (low - 1);

            for (int j = low; j <= high; j++)
            {
                //If the current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    //Increment the index of the smaller element
                    i++;
                    SwapElements(arr, i, j);
                }
            }
            SwapElements(arr, i + 1, high);
            return (i + 1);
        }

        static void QuickSortMethod(int[] arr, int low, int high)
        { //High is the length-1 of the array
            if (low < high)
            {
                //int part is partitioning index, array
                int part = PartitionElements(arr, low, high);
                // Separately sort elements before and after partition index
                QuickSortMethod(arr, low, part - 1); //Left side of the pivot
                QuickSortMethod(arr, part + 1, high); //Right side of the pivot
            }
        }
    }
}
