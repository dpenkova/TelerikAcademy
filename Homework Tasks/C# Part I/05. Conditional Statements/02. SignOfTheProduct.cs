/* Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
 * Use a sequence of if statements. */

using System;

class SignOfTheProduct
{
    static void Main()
    {
        double firstNumber;
        double secondNumber;
        double thirdNumber;

        Console.Write("Enter you first number: ");
        while (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.Write("Invalid entry! Try again: ");
        }
        Console.Write("Enter you second number: ");
        while (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.Write("Invalid entry! Try again: ");
        }
        Console.Write("Enter you third number: ");
        while (!double.TryParse(Console.ReadLine(), out thirdNumber))
        {
            Console.Write("Invalid entry! Try again: ");
        }

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("\nThe product of your three numbers will be Zero.\n");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0
            || firstNumber > 0 && secondNumber < 0 && thirdNumber < 0
            || firstNumber < 0 && secondNumber < 0 && thirdNumber > 0
            || firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("\nThe product of your three numbers will be Positive.\n");
        }
        else 
        {
            Console.WriteLine("\nThe product of your three numbers will be Negative.\n");
        }
    }
}
