/* Write a program that reads an integer number and calculates and prints its square root. 
* If the number is invalid or negative, print "Invalid number". In all cases 
* finally print "Good bye". Use try-catch-finally.*/

using System;

class InvalidNumberEx
{
    static void CalculateAndPrintSqrt(string input)
    {
        int number = int.Parse(input);

        if (number < 0)
        {
            throw new ArgumentException();
        }
        else
        {
            Console.WriteLine("The square root of {0} is {1}", input, Math.Sqrt(number));
        }
    }

    static void Main()
    {
        Console.Write("Enter one positive integer: ");
        string input = Console.ReadLine();

        try
        {
            CalculateAndPrintSqrt(input);
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (ArgumentException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
