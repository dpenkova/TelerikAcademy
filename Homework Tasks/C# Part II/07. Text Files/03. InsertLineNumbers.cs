/* Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file.*/

using System;
using System.IO;
using System.Linq;
using System.Text;

class InsertLineNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the full path to your file and the file name: ");
        string path = Console.ReadLine();
        StreamReader fileReader = new StreamReader(path, Encoding.GetEncoding("windows-1251"));

        Console.WriteLine("Enter the full path and file name for your result file: ");
        string resultPath = Console.ReadLine();
        StreamWriter writer = new StreamWriter(resultPath, false, Encoding.GetEncoding("windows-1251"));

        using (fileReader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line = fileReader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    writer.WriteLine("{0} : {1}", lineNumber, line);
                    line = fileReader.ReadLine();
                }
            }
        }
    }
}

