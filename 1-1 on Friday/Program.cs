namespace _1_1_on_Friday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = { "A", "B", "C", "D", "E", "F" };

            for (int loopCounter = 0; loopCounter < letters.Length; loopCounter++)
            {
                Console.WriteLine(letters[loopCounter]);
            }





            //While loop starts here 
            int counter = 0; //This is based as 0


            while (letters[counter] !="") //Look up understanding a while loop
            { //The counter is just named counter to start the array at 0
             
               counter++;
                Console.WriteLine(counter); //This is displaying the counter from 0-6
            }
            





            //for (int loopCounter = 0;loopCounter < letters.Length;loopCounter++)
            //{


            //}

            int i = 0;
            while (i < 5); //This will have the code display until this is FALSE
            {
                
                Console.WriteLine(i);
                i++;
            }

            int Practice = 0;
            do
            {
                Console.WriteLine(Practice);
                Practice++;
            }
            while (Practice < 5);


        }
    }
}
