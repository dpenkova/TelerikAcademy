/* Write a program that encodes and decodes a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. The encoding/decoding is done by performing XOR 
 * (exclusive or) operation over the first letter of the string with the first of the key, 
 * the second – with the second, etc. When the last key character is reached, the next is the first. */

using System;
using System.Text;

class EncoderDecoder
{
    public static string Coder(string text, string key)
    {
        StringBuilder codedResult = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            codedResult.Append((char)(text[i] ^ key[i % key.Length]));
        }

        return codedResult.ToString();
    }

    static void Main()
    {
        Console.Write("Enter a text to code and decode: ");
        string text = Console.ReadLine();
        Console.Write("Enter your coding key: ");
        string key = Console.ReadLine();

        string encodedText = Coder(text, key);

        Console.WriteLine("Encoded text:");
        Console.WriteLine(encodedText);
        Console.WriteLine();
        Console.WriteLine("Decoded text: \n{0}\n", Coder(encodedText, key));

        Main();
    }
}

