/* Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

using System;
using System.Text.RegularExpressions;

class ExtractPalindromes
{
    static void Main()
    {
        string input = @"Най-старите открити палиндроми датират от преди около 2000 години.
                        Примери са: Сос, Боб, Потоп, радар, кок, PHP, level, ABBA, рефер, Ревер, etc. ";

        string pattern = @"\s+|\,\s*|\;\s*|\:\s*|\-\s*|!\s*|\?\s*|\.\s*|„\s*|“\s*";

        string[] matches = Regex.Split(input, pattern);

        foreach (string match in matches)
        {
            if (IsPalindrome(match))
            {
                Console.WriteLine(match);
            } 
        }
    }

    static bool IsPalindrome(string word)
    {
        word = word.ToUpper();

        if (word.Length > 2)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
        else return false;
    }
}