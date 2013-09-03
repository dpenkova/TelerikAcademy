/*Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/

using System;
using System.Text.RegularExpressions;

class CheckBrackets
{
    static void Main()
    {
        Console.Write("Enter your expression: ");
        string input = Console.ReadLine();

        Console.WriteLine("{0} expression.", BracketsChecker(input) ? "Correct" : "Incorrect");

        Main();
    }

    public static bool BracketsChecker(string input)
    {
        int countLeftBracket = Regex.Matches(input, "[(]").Count;
        int countRightBracket = Regex.Matches(input, "[)]").Count;

        bool result = countLeftBracket == countRightBracket;
        return result;
    }
}