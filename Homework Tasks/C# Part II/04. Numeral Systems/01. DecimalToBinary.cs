/* Write a program to convert decimal numbers to their binary representation.*/

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter one integer: ");
        int input = int.Parse(Console.ReadLine());
        int numeralSystem = 2;

        string result = "";

        while (input > 0)
        {
            result += input % numeralSystem;
            input = input / numeralSystem;
        }

        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write("{0}", result[i]);
        }

        Console.WriteLine();
        Main();
    }
}

