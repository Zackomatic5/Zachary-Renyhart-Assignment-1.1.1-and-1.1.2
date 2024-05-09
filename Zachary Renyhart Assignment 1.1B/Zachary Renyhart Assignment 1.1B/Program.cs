// See https://aka.ms/new-console-template for more information
using System.Numerics;
//This is the start of question 3.
Console.WriteLine("Hello, If you have 15 apples and 30 oranges. What is the total amount of fruit you have?");
int num1 = 15;
int num2 = 30;
//This is taking the value of the components above and adding them together.
int sum1 = num1 + num2;
Console.WriteLine("Please enter a value!...");
Convert.ToInt32(Console.ReadLine());    
Console.WriteLine(sum1);
Console.WriteLine("That is correct! Great job");

Console.ForegroundColor = ConsoleColor.Blue;
//This is the start of question 4
Console.WriteLine("Fantastic now time for question 4!");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("What is 10567 divided by 37");
double num3 = 10567;
double num4 = 37;
//This is getting the sum of 10567 divided by 37.
double sum2 = num3 / num4;
Console.WriteLine("Please enter a value!...");
Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum2);
Console.WriteLine("Wow! That is a really big number! If you got that, you're a genious!");
Console.WriteLine("Thank you for participating! Have a great day");

