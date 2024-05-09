// See https://aka.ms/new-console-template for more information
//This is for the first part of the assignment
string myName;
Console.WriteLine("Please enter your name");
myName = Console.ReadLine();

//This is asking the user what their age is.
Console.WriteLine("What is your age?");
int myAge = Convert.ToInt32(Console.ReadLine());

//This is asking the user what their address is.
string myAddress;
Console.WriteLine("What is your address?");
myAddress = Console.ReadLine();
Console.WriteLine("My name is " + myName);
Console.WriteLine("My age is " + myAge);
Console.WriteLine("My address is " + myAddress);

//This is the start of Question 2
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("This is the start of question 2 of the HW assignment");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("This is the min and max of an int");
int x = 6;
int y = 15;
//This is finding the max value between x and y.
Console.WriteLine(Math.Max(x, y));
//This is finding the min value between x and y.
Console.WriteLine(Math.Min(x, y));


float alpha = 4.5645F;
float charlie = 7.6756F;
Console.WriteLine("This is the min and max of a float");
//This is the max of the float
Console.WriteLine(Math.Max((float)alpha, charlie));
//This is the min of the float
Console.WriteLine(Math.Min((float)alpha, charlie));

decimal sum1 = 0.8676M;
decimal sum2 = 0.2335M;
Console.WriteLine("This is the min and max of a decimal");
//This is the min of a decimal
Console.WriteLine(Math.Min((decimal)sum1, sum2));   
//This is the max of a decimal
Console.WriteLine(Math.Max((decimal)sum1, sum2));

double myNumD1 = 17.99D;
double myNumD2 = -7.99D;
Console.WriteLine("This is the min and max of a double");
//This is the max of the double
Console.WriteLine(Math.Max((double)myNumD1, myNumD2));
//This is the min of the double
Console.WriteLine(Math.Min((double)myNumD1, myNumD2));
Console.WriteLine("Thank you, Have a great day!");