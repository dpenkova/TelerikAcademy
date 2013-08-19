/* Write a method ReadNumber(int start, int end) that enters an integer number in given 
* range [start…end]. If an invalid number or non-number text is entered, the method 
* should throw an exception. Using this method write a program that enters 10 numbers:
		a1, a2, … a10, such that 1 < a1 < … < a10 < 100     */

using System;

class ReadTenNumbersInRange
{
    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter one integer number in the range [{0} - {1}] : ", start + 1, end);
        int number = int.Parse(Console.ReadLine());

        if (!(start < number && number <= end))
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            return number;
        }
    }

    static void Main()
    {
        int min = 0, max = 90;
        
        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                try
                {
                    min = ReadNumber(min, max);
                    max++;
                    break;
                }
                catch (OverflowException)
                {
                    Console.Error.WriteLine("Invalid input. Enter a valid integer number.");
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Invalid input. Enter a valid integer number.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("Invalid input. Enter a valid integer number.");
                }
            }
        }
    }
}
