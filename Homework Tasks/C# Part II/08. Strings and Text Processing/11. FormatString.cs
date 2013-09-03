/* Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage 
 * and in scientific notation. Format the output aligned right in 15 symbols. */

using System;
using System.Text;

class FormatString
{
    static void Main()
    {
        Console.Write("Enter one number: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D}: Decimal", input);
        Console.WriteLine("{0,15:X}: Hexadecimal", input);
        Console.WriteLine("{0,15:P}: Percentage", input);
        Console.WriteLine("{0,15:E}: Scientific notation", input);
    }
}