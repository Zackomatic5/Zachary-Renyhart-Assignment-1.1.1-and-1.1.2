using System.ComponentModel.Design;

namespace Practice_Assesement___Day_29_
{
    internal class Program
    {
        static void Main(string[] args)
        {   //This is the starting array!
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            Console.Write("This is the starting array: ");
            DisplayArray(array);
            Console.WriteLine();
            Console.Write("This is the reverse array: ");
            ReverseArray(array);
            DisplayArray(array);

            Console.WriteLine();
            Console.Write("This is the elements swapped in the array: ");
            ReverseElements(array);
            DisplayArray(array);

            Console.WriteLine();

            Console.WriteLine("Please enter letters with vowels: ");
            string letters = Console.ReadLine().ToLower();
            Console.Write(ReverseVowel(letters));

            //Using a while loop to reverse the array.
            //I is equal to the last element in the array
            int i = array.Length - 1;
            while (i > 0)
            {
                Console.Write(i + " ");
                i--;
            }





        }


        //This is the method to display the array.
        static void DisplayArray(int[] array)
        {
            foreach (int i in array)
            {

                Console.Write(i + " ");
            }
        }

        static void ReverseArray(int[] array)
        {   //array.length-1-i is the last element in the array and decrementing by i everytime.
            //We are dividing the array in half with array.length-1-i / 2

            for (int i = 0; i < array.Length / 2; i++)
            {

                //This is swapping the elements in the array.
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;


            }
        }

        static void ReverseElements(int[] array)
        {
            //This is incrementing the for loop by 2 everytime
            int temp = 0;
            for (int i = 0; i < array.Length / 2; i += 2)
            {

                //This is swapping the elements in the array.
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;




            }
        }

        static bool IsVowel(char ch)
        {
            return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
        }

        static string ReverseVowel(string str)
        {

            int i = 0; //I is equal to the first character
            int j = str.Length - 1; //J is equal to the last character
            char[] str1 = str.ToCharArray();
            while (i < j) //While this is true, this code will perform
            {
                if (!IsVowel(str1[i])) //If i does not equal a vowel it will ++ and continue
                {
                    i++;
                    continue;
                }
                if (!IsVowel(str1[j])) //If j does not equal a vowel it will ++ and continue
                {
                    j--;
                    continue;
                }

                char temp = str1[i]; //If they are vowels this swaps the characters
                str1[i] = str1[j];
                str1[j] = temp;

                i++;
                j--;
            }
            string str2 = String.Join("", str1);
            return str2;
        }




        //Leetcode
        public void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
            //Accepted on Leetcode #344.

            {
                //This is another way to do it too
                int left = 0;
                int right = s.Length - 1;
                while (left < right)
                {
                    // Swap the characters at the left and right indices
                    char temp = s[left];
                    s[left] = s[right];
                    s[right] = temp;

                    // Move the pointers towards the center
                    left++;
                    right--;
                }

            }
        }

        static int[] SelSort(int[] input)
        {   //THIS IS A SELECTION SORT
            int[] result;
            int n = input.Length; //n-1 is the last element
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i + 1;
                for (int j = i + 1; j == n - 2; j++)
                {   //This is the minimum element when iterating through the array.
                    //If input J is less than min!
                    if (input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }

                    int temp = input[i];
                    input[i] = input[minIndex];
                    input[minIndex] = temp;
                }
            }

            return input;
        }
        public bool IsSymmetric(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root.left);
            queue.Enqueue(root.right);

            while (queue.Count > 0)
            {
                TreeNode left = queue.Dequeue();
                TreeNode right = queue.Dequeue();

                if (left == null && right == null)
                {   //If both sides of the tree == null then they could be equal.
                    continue;
                }
                else if (left == null || right == null)
                {   //If one of the nodes are null its not symmetiral
                    return false;
                }
                else if (left.value != right.value)
                {   //If the value of nodes are not equal this will return false.
                    return false;
                }
                else
                {   //This is pushing the left and right subtrees of the left and
                    //right nodes onto the queue in opposite order
                    queue.Enqueue(left.left);
                    queue.Enqueue(right.right);
                    queue.Enqueue(left.right);
                    queue.Enqueue(right.left);
                }
            }

            return true;
        }

    }
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value = 0, TreeNode left = null, TreeNode right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

    }
}
