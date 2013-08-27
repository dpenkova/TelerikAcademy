/* Write a program that deletes from given text file all odd lines. 
 * The result should be in the same file.*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteOddLines
{
    static void Main()
    {
        Console.WriteLine("Enter your file name and path:");
        string path = Console.ReadLine();

        using (StreamReader reader = new StreamReader(path))
        {
            using (StreamWriter writer = new StreamWriter(Path.GetDirectoryName(path) + @"\temp.txt"))
            {
                string line;
                int lineNumber = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;

                    if (lineNumber % 2 == 0)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        File.Delete(path);
        File.Move(Path.GetDirectoryName(path) + @"\temp.txt", path);

        Console.WriteLine("Ready!");
    }
}