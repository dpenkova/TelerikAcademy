/* Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
 * Print the result string into the console.*/

using System;

class Max20Chars
{
    static void Main()
    {
        Console.Write("Enter a satring of maximun 20 characters: ");
        string input = Console.ReadLine();

        while (input.Length > 20)
        {
            Console.Write("Invalid entry! Try again: ");
            input = Console.ReadLine();
        }

        Console.WriteLine(input.PadRight(20, '*'));
    }
}