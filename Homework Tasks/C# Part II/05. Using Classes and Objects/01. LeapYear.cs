/* Write a program that reads a year from the console and checks 
 * whether it is a leap. Use DateTime.*/

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter one year to check if it is a leap year: ");
        int inputYear = int.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(inputYear);

        Console.WriteLine("{0} {1} a leap year", inputYear, isLeap ? "is" : "is not");

        Main();
    }
}