/*Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements. */

using System;

class GreaterNumber
{
    static void Main()
    {        
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(firstNumber, secondNumber));

        // or second way
        //Console.WriteLine((firstNumber + secondNumber + Math.Abs(firstNumber - secondNumber))/2);
    }
}