/* Write a program that compares two text files line by line and prints the number of lines 
 * that are the same and the number of lines that are different. 
 * Assume the files have equal number of lines. */

using System;
using System.IO;
using System.Linq;
using System.Text;

class CompareTwoFiles
{
    static void Main()
    {
        Console.WriteLine("Enter the full path to your first file with the file name: ");
        string pathOne = Console.ReadLine();
        StreamReader fileReaderOne = new StreamReader(pathOne, Encoding.GetEncoding("windows-1251"));

        Console.WriteLine("Enter the full path to your second file with the file name: ");
        string pathTwo = Console.ReadLine();
        StreamReader fileReaderTwo = new StreamReader(pathTwo, Encoding.GetEncoding("windows-1251"));
        
        int countEqual = 0;
        int countDiff = 0;

        using (fileReaderOne)
        {
            string lineOne = fileReaderOne.ReadLine();

            using (fileReaderTwo)
            {
                string lineTwo = fileReaderTwo.ReadLine();

                while (lineOne != null)
                {
                    if (lineOne == lineTwo)
                    {
                        countEqual++;
                    }
                    else 
                    {
                        countDiff++;
                    }

                    lineOne = fileReaderOne.ReadLine();
                    lineTwo = fileReaderTwo.ReadLine();
                }
            }
        }

        Console.WriteLine("Ready!\nNumber of equal lines: {0}\nNumber of different lines: {1}", countEqual, countDiff );
    }
}

