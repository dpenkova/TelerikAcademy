/* Write a program that reads a string from the console and prints all different letters in the string 
 * along with information how many times each letter is found. */

using System;

class CountLetters
{
    static void Main()
    {
       //string input = @"Lorem Ipsum, is simply dummy text.";

        Console.WriteLine("Enter some text: ");
        string input = Console.ReadLine();

        int[] counter = new int['z' - 'a' + 1];

        foreach (char ch in input.ToLower())
        {
            if ('a' <= ch && ch <= 'z')
            {
                counter[ch - 'a']++;
            }
        }

        for (int i = 0; i < counter.Length; i++)
        {
            if (counter[i] != 0)
            {
                Console.WriteLine("{0}: {1}", (char)(i + 'a'), counter[i]);
            }
        }
    }
}