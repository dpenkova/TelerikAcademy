/* Write a program to convert hexadecimal numbers to their decimal representation. */

using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter one hexadecimal number: ");
        string input = Console.ReadLine().ToUpper();

        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int numeralSystem = 16;

        List<int> inputList = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < symbols.Length; j++)
            {
                if (input[i] == symbols[j])
                {
                    inputList.Add(j);
                }
            }
        }

        int result = 0;

        for (int i = inputList.Count - 1; i >= 0; i--)
        {
            result += int.Parse(inputList[i].ToString()) * (int)Math.Pow(numeralSystem, inputList.Count - 1 - i);
        }

        Console.WriteLine("Decimal representation: {0}", result);
        Console.WriteLine(new string('=', 40));
        Main();
    }
}