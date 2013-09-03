/* A dictionary is stored as a sequence of text lines containing words and their explanations. 
 * Write a program that enters a word and translates it by using the dictionary. 
 * Sample dictionary:
 * .NET – platform for applications from Microsoft
 * CLR – managed execution environment for .NET
 * namespace – hierarchical organization of classes */

using System;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string dictionary = @".NET - platform for applications from Microsoft
                            CLR - managed execution environment for .NET
                            namespace - hierarchical organization of classes";
        Console.Write("Enter your searched word: ");
        string word = Console.ReadLine();
        string pattern = word + @"\s+\-\s*?(?<result>.+)";

        MatchCollection matches = Regex.Matches(dictionary, pattern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

        if (matches.Count > 0)
        {
            foreach (Match item in matches)
            {
                Console.WriteLine("{0} is : {1}", word, item.Groups["result"]);
            }
        }
        else
        {
            Console.WriteLine("The searched word is not found in the dictionary.");
        }

        Main();
    }
}