/* Write a program that deletes from a text file all words that start with 
 * the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsStartingWithTest
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

                while ((line = reader.ReadLine()) != null)
                {
                    line = Regex.Replace(line, @"\btest\w+\b", String.Empty, RegexOptions.IgnoreCase);
                    writer.WriteLine(line);
                }
            }
        }

        File.Delete(path);
        File.Move(Path.GetDirectoryName(path) + @"\temp.txt", path);

        Console.WriteLine("Ready!");

        // other way
        //string fileContent = File.ReadAllText(path);
        //File.WriteAllText(path,Regex.Replace(fileContent, @"\b(test\w*)\b", String.Empty, RegexOptions.IgnoreCase));
    }
}