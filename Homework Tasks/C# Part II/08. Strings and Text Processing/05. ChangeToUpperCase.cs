/* You are given a text. Write a program that changes the text in all regions surrounded by the tags 
 * <upcase> and </upcase> to uppercase. The tags cannot be nested. 
 * 
 * Example:
 * We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

 * The expected result:
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else. */

using System;
using System.Text.RegularExpressions;

class ChangeToUpperCase
{
    static void Main()
    {
        string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string pattern = @"<upcase>(?<up>(.+?))</upcase>";
        string result = Regex.Replace(input, pattern, match => match.Groups["up"].Value.ToUpper());
        Console.WriteLine(result);
    }
}