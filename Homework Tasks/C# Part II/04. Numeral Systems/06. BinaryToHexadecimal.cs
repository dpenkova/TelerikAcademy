/* Write a program to convert binary numbers to hexadecimal numbers (directly) */

using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static void Main()
    {
        string[,] matrix = 
        {
            { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" },
            { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" }
        };

        Console.Write("Enter one binary number: ");
        string input = Console.ReadLine();
        input = input.Replace(" ", null);

        string result = "";

        if (input.Length % 4 != 0)
        {
            int pos = 4 - input.Length % 4;
            input = RebuildInput(input, pos);
        }

        int i = input.Length - 1;

        while (i >= 0)
        {
            string temp = input[i - 3].ToString() + input[i - 2].ToString() + input[i - 1].ToString() + input[i].ToString();
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[1, j] == temp)
                {
                    result += matrix[0, j];
                    break;
                }
            }
            i -= 4;
        }
        
        Console.Write("Hexadecimal representation: ");

        for (int j = result.Length - 1; j >= 0; j--)
		{
			Console.Write(result[j]);
		}

        Console.WriteLine();
        Console.WriteLine(new string('=', 40));

        Main();
    }

    static string RebuildInput(string input, int p)
    {
        List<char> a = new List<char>();

        foreach (var item in input)
        {
            a.Add(item);
        }

        for (int i = 1; i <= p; i++)
        {
            a.Add('0');

            for (int j = a.Count - 2; j >= 0 ; j--)
            {
                a[j + 1] = a[j];
            }

            a[0] = '0';
        }

        input = "";

        foreach (var item in a)
        {
            input += item;
        }

        return input;
    }
}
