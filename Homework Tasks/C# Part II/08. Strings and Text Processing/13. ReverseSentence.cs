/* Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!". */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        string regexPattern = @"\s+|\,\s*|\;\s*|\:\s*|\-\s*|!\s*|\?\s*|\.\s*";

        string[] sentenceWords = Regex.Split(input, regexPattern);

        Stack<string> words = new Stack<string>();

        for (int i = 0; i < sentenceWords.Length; i++)
        {
            if (sentenceWords[i] != "")
            {
                words.Push(sentenceWords[i]);
            }
        }

        MatchCollection sentenceSeparators = Regex.Matches(input, regexPattern);

        Queue<string> separators = new Queue<string>();

        foreach (Match separator in sentenceSeparators)
        {
            separators.Enqueue(separator.ToString());
        }

        StringBuilder outputResult = new StringBuilder(input.Length);

        while (words.Count > 0 && separators.Count > 0)
        {
            outputResult.Append(words.Pop());
            outputResult.Append(separators.Dequeue());
        }

        Console.WriteLine(outputResult);
    }
}