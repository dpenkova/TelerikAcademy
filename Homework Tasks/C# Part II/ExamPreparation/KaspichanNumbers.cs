using System;
using System.Collections.Generic;

class KaspichanNumbers
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());

        List<string> kaspichanNumbers = new List<string>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            kaspichanNumbers.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                kaspichanNumbers.Add(i.ToString() + j.ToString());
            }
        }

        //for (int i = 0; i < kaspichanNumbers.Count; i++ )
        //{
        //    Console.WriteLine("{0, 3} : {1}", i, kaspichanNumbers[i]);
        //}

        string output = string.Empty;

        if (input == 0)
        {
            Console.WriteLine(kaspichanNumbers[(int)input]);
        }
        else
        {
            while (input != 0)
            {
                output = kaspichanNumbers[(int)(input % 256)] + output;
                input = input / 256;
            }
        }

        Console.WriteLine(output);
    }
}