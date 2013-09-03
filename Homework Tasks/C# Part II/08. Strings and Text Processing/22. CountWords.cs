/* Write a program that reads a string from the console and lists all different words in the string along 
 * with information how many times each word is found.*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class CountWords
{
    static void Main()
    {
        //string input = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
        Console.WriteLine("Enter some text: ");
        string input = Console.ReadLine();

        string regexPattern = @"\s+|\,\s*|\;\s*|\:\s*|\-\s*|!\s*|\?\s*|\.\s*|'\s*|\(\s*|\)\s*|<\s*|>\s*|\\\s*";

        string[] textWords = Regex.Split(input, regexPattern);

        Dictionary<string, int> words = new Dictionary<string, int>();

        foreach (string word in textWords)
        {
            if (word.Length > 1)
            {
                if (words.ContainsKey(word.ToLower()))
                {
                    words[word.ToLower()]++;
                }
                else
                {
                    words.Add(word.ToLower(), 1);
                }
            }
        }

        foreach (KeyValuePair<string, int> pair in words.OrderByDescending(m => m.Value))
        {
            Console.WriteLine("{0, -15} : {1}", pair.Key, pair.Value);
        }
    }
}