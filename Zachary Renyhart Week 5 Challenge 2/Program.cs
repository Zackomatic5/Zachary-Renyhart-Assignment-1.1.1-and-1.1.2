namespace Zachary_Renyhart_Week_5_Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 5, 6, 7 };
            HashSet<int> num = new HashSet<int>();
            //A Hashset holds one unique value instead of a dictionary which is a Key, Value.
            //A Hashset is like a dictionary but it holds only one value when a dictionary holds a key and a value
            foreach (int index in array) 
            {
                //This is adding every number to the Hashset
                num.Add(index);
            }
            for (int i = 1; i < array.Length; i++)
            {   //If the dictionary does not contain the index of the forloop. I will display the missing number
                if (!num.Contains(i))
                {
                    Console.WriteLine($"The number that is missing is: {i}");
                }
            }

        }
       
    }
}
