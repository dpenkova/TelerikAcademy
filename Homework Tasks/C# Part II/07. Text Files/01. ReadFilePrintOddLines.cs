/* Write a program that reads a text file and prints on the console its odd lines. */

using System;
using System.IO;
using System.Linq;
using System.Text;

class ReadFilePrintOddLines
{
    static void Main()
    {
        Console.WriteLine("Enter the full path to your file and the file name: ");
        string path = Console.ReadLine();
        StreamReader fileReader = new StreamReader(path, Encoding.GetEncoding("windows-1251"));

        using (fileReader)
        {
            int lineNumber = 0;
            string line = fileReader.ReadLine();
            while (line != null)
            {
                lineNumber++;

                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                line = fileReader.ReadLine();
            }
        }
    }
}

