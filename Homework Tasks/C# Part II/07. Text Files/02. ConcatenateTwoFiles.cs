/* Write a program that concatenates two text files into another text file. */

using System;
using System.IO;
using System.Linq;
using System.Text;

class ConcatenateTwoFiles
{
    static void Main()
    {
        Console.WriteLine("Enter the full path to your first file with the file name: ");
        string pathOne = Console.ReadLine();
        StreamReader fileReaderOne = new StreamReader(pathOne, Encoding.GetEncoding("windows-1251"));

        Console.WriteLine("Enter the full path to your second file with the file name: ");
        string pathTwo = Console.ReadLine();
        StreamReader fileReaderTwo = new StreamReader(pathTwo, Encoding.GetEncoding("windows-1251"));

        Console.WriteLine("Enter the full path to your concatenation result file with the file name: ");
        string resultPath = Console.ReadLine();
        StreamWriter writerOne = new StreamWriter(resultPath, false, Encoding.GetEncoding("windows-1251"));
                
        using (fileReaderOne)
        {
            string fileContent = fileReaderOne.ReadToEnd();
            using (writerOne)
            {
                writerOne.Write(fileContent + "\n\r");
            }
        }

        StreamWriter writerTwo = new StreamWriter(resultPath, true, Encoding.GetEncoding("windows-1251"));
        
        using (fileReaderTwo)
        {
            string fileContent = fileReaderTwo.ReadToEnd();
            using (writerTwo)
            {
                writerTwo.Write("\n" + fileContent);
            }
        }

        Console.WriteLine("Ready the two files are concatenated in one: {0}", resultPath);
    }
}

