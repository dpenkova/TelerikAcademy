/* Write a program that reads 3 integer numbers from the console and prints their sum. */

using System;

class ReadThreeIntegers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}", firstNumber + secondNumber + thirdNumber);
    }
}

