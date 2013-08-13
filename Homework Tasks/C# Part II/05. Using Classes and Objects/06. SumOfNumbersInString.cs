/* You are given a sequence of positive integer values written into a string, separated 
 * by spaces. Write a function that reads these values from given string and calculates 
 * their sum. Example: string = "43 68 9 23 318" -> result = 461 */

using System;

class SumOfNumbersInString
{
    static void Main()
    {
        Console.WriteLine("Enter several numbers separated by intervals:");

        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += int.Parse(numbers[i]);
        }

        Console.WriteLine(sum);

        Main();
    }
}
