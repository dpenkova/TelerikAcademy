/* Write a program to convert binary numbers to their decimal representation.*/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter one binary number: ");
        string input = Console.ReadLine().Replace(" ", null);

        int numeralSystem = 2;
        int result = 0;

        for (int i = input.Length - 1 ; i >= 0; i--)
        {
            result += int.Parse(input[i].ToString()) * (int)Math.Pow(numeralSystem, input.Length - 1 - i);
        }

        Console.WriteLine(result);
        Main();
    }
}
