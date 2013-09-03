/* Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order. */

using System;

class SortWords
{
    static void Main()
    {
        //string input = "some words here like cat dog order";

        Console.WriteLine("Enter a list of words, separated by spaces: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}