/* Write a program that creates an array containing all letters 
 * from the alphabet (A-Z). Read a word from the console and print 
 * the index of each of its letters in the array.*/

using System;

    class CharArray
    {
        static void Main()
        {
            char[] alphabet = new char[26];
            
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 65);
            }

            foreach (var item in alphabet)
            {
                Console.Write("{0} |", item);
            }
            Console.WriteLine();

            Console.Write("Write a word: ");
            string word = Console.ReadLine();
            word = word.ToUpper();

            for (int w = 0; w < word.Length;  w++ )
            {
                for (int a = 0; a < alphabet.Length; a++)
                {
                    if (word[w] == alphabet[a])
                    {
                        Console.Write("{0} |", a);
                        break;
                    }
                }
            }
            Console.WriteLine();
            Main();
        }
    }