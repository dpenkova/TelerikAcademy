/* Write a program that converts a string to a sequence of C# Unicode character literals. 
 * Use format strings. Sample input: Hi!
 * Expected output: \u0048\u0069\u0021       */

using System;
using System.Text;

class ConvertToUnicode
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
		{
			Console.Write("\\u{0:x4}", (ushort)input[i]);
		}

        Console.WriteLine();
        Main();
    }
}