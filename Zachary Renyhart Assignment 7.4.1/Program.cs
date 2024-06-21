using System.Numerics;

namespace Zachary_Renyhart_Assignment_7._4._1
{
    internal class Program
    {
      
        static void Main(string[] args)
        {   //This is calling out 2 big spot, 3 medium spot, 0 small spots
              ParkingSystem parking = new (2,3,0);
            //This is parking a big car
            Console.WriteLine("Please enter 1 to park a big car, 2 to park a medium car and 3 to park a small car");
           int output = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{parking.addCar(output)}");
     
        }
       
    }

    public class ParkingSystem
    {
        
        private int bigSpots;
        private int mediumSpots;
        private int smallSpots;
        //Below is a class constructor with multiple parameters
        public ParkingSystem(int big, int medium, int small)
        {
            bigSpots = big;
            mediumSpots = medium;
            smallSpots = small;


        }
        public bool addCar(int carType)
        {
            switch (carType)
            {
                //Above where I enstantiate the class and add numbers to the constructor is how man
                case 1: // Big car
                    //If Bigslots is bigger than 0 then it will return true and decrement by 1.
                    if (bigSpots > 0)
                    {
                        bigSpots--;
                        Console.WriteLine("Access granted!");
                        return true;
                    }
                    //If Bigslots = 0 that means no more spots are available and this will enter false.
                    return false;
                   
                case 2: // Medium car
                    if (mediumSpots > 0)
                    {
                        mediumSpots--;
                        Console.WriteLine("Access granted!");
                        return true;
                    }
                    return false;
                case 3: // Small car
                    if (smallSpots > 0)
                    {
                        smallSpots--;
                        Console.WriteLine("Access granted!");
                        return true;
                    }
                    return false;
                default:
                    return false; // Invalid car type
                   

            }
        }
    }
    
}
