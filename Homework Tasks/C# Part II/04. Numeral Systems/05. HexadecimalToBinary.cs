/* Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;

class HexadecimalToBinary
{
    static void Main()
    {
        string[,] matrix = 
        {
            { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" },
            { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" }
        };

        Console.Write("Enter one hexadecimal number: ");
        string input = Console.ReadLine().ToUpper();

        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[0, j] == input[i].ToString())
                {
                    result += matrix[1, j];
                }
            }
        }

        Console.WriteLine("Binary representation: {0}", result);
        Console.WriteLine(new string('=', 40));
        Main();
    }
}
