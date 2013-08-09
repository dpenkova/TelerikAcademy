/* Write a method that reverses the digits of given decimal number. Example: 256 -> 652 */

using System;

class ReverseDigits
{
    static void Main()
    {
        Console.Write("Enter one integer: ");
        string input = Console.ReadLine();
        Console.WriteLine("{0} -> {1}", input, ReverseDigitsMethod(input));
        Console.WriteLine(new string('=', 17));
        Main();
    }
    static int ReverseDigitsMethod(string inputNumber)
    {
        int numberLength = inputNumber.Length;
        int input = int.Parse(inputNumber);
        string output = null;

        for (int i = 0; i < numberLength; i++)
        {
            int last = input % 10;
            output = output + last.ToString();
            input = input / 10;
        }
        return int.Parse(output);
    }
}