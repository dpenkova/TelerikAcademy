/* Write a program that finds how many times a substring is contained in a given text 
 * (perform case insensitive search).
    Example: The target substring is "in". The text is as follows:
 * We are living in an yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. So we are drinking all the day. 
 * We will move out of it in 5 days.
The result is: 9.  */

using System;
using System.Text.RegularExpressions;

class CountContainedSubstring
{
    static void Main()
    {
        Console.WriteLine("Enter your text to look in:");
        string input = Console.ReadLine();

        Console.Write("Enter the searched substring: ");
        string pattern = Console.ReadLine();

        int counter = Regex.Matches(input, pattern, RegexOptions.IgnoreCase).Count;

        Console.WriteLine("The result is: {0}", counter);
        Main();
    }
}