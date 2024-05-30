namespace Zachary_Renyhart_Challenge_Problem_4._2
{
    internal class Program
    {

        //Dictionary has to go up here, you have to make this static
        static Dictionary<string, int> _selectionCount = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            Dictionary();

        }
        public static void Dictionary()
        {
            int[] array = { 16, 23, 12, 12, 20 };
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (int element in array)
            {
                if (dictionary.ContainsKey(element))
                {   //If the "Element" of the array is alreayd in the dictionary. This will add 1
                    dictionary[element]++;

                }
                else
                { //If the Element of the array is not in the dictionary it will add 1 to its count
                    dictionary[element] = 1;
                }

            } //Defines a key/value pair that can be set or retrieved.
            foreach (KeyValuePair<int, int> pair in dictionary)
            {                                   
                Console.WriteLine("{0} occurs {1} times", pair.Key, pair.Value);
            }
        }    
    }   
}
