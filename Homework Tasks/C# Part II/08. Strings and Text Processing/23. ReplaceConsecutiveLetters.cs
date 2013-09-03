/* Write a program that reads a string from the console and replaces all series of consecutive identical letters 
 * with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".   */

using System;
using System.Text.RegularExpressions;

class ReplaceConsecutiveLetters
{
    static void Main()
    {
        //string input = "aaaaabbbbbcdddeeeedssaa orrrr likeeeeee hhhhaaaaaahhhhhhhaaaahhaaa";
        
        Console.Write("Enter some string: ");
        string input = Console.ReadLine();

        string pattern = @"(\w)\1+";

        Console.WriteLine(Regex.Replace(input, pattern, "$1"));
    }
}