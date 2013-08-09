/* Write a method GetMax() with two parameters that returns the bigger of two integers. 
* Write a program that reads 3 integers from the console and prints the biggest of them 
* using the method GetMax().*/

using System;

class GetMaxMethod
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int maxNumber = GetMax(firstNumber, secondNumber);
        maxNumber = GetMax(maxNumber, thirdNumber);

        Console.WriteLine("The biggest of your three numbers is: {0}", maxNumber);

        Main();
    }

    static int GetMax(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        else 
        { 
            return second; 
        }
    }
}