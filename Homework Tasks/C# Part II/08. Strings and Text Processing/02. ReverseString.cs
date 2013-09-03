/* Write a program that reads a string, reverses it and prints the result at the console.
   Example: "sample" -> "elpmas".*/

using System;
using System.Text;

class ReverseString
{
    public static string ReversedString(string input)
    {
        StringBuilder output = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            output.Append(input[i]);
        }
        return output.ToString();
    }

    static void Main() 
    {
        Console.Write("Enter string to reverse: ");
        string input = Console.ReadLine();
        Console.WriteLine("Reversed string: {0}", ReversedString(input));
        Main();
    }
}