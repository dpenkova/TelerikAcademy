/* Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter one integer: ");
        int input = int.Parse(Console.ReadLine());
        int numeralSystem = 16;

        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        List<int> result = new List<int>();

        while (input > 0)
        {
            result.Add(input % numeralSystem);
            input = input / numeralSystem;
        }
        result.Reverse();

        List<char> finalResult = new List<char>();

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < symbols.Length; j++)
            {
                if (result[i] == j)
                {
                    finalResult.Add(symbols[j]);
                }
            }
        }

        Console.Write("Hexadecimal representation: ");

        foreach (var item in finalResult)
        {
            Console.Write("{0}", item);
        }

        Console.WriteLine();
        Console.WriteLine(new string('=', 40));

        Main();
    }
}

