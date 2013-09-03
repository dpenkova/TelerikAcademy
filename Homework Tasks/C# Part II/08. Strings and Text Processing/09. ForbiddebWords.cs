/* We are given a string containing a list of forbidden words and a text containing some of these words. 
 * Write a program that replaces the forbidden words with asterisks. Example:
 * Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 
 * and is implemented as a dynamic language in CLR.
 * Words: "PHP, CLR, Microsoft"
    The expected result:
********* announced its next generation *** compiler today. 
 *It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.  */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ForbiddebWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbiddenWords = "PHP, CLR, Microsoft";

        string pattern = forbiddenWords.Replace(", ", "|");

        //string[] wordsArray = forbiddenWords.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //string pattern = @"\b(" + String.Join("|", wordsArray) + @")\b";

        string result = Regex.Replace(text, pattern, match => new String('*', match.Length));
        Console.WriteLine(result);
    }
}