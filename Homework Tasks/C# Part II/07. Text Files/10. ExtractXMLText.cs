/* Write a program that extracts from given XML file all the text without the tags. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractXMLText
{
    static void Main()
    {
        Console.WriteLine("Enter the name and path to your .xml file: ");

        string path = Console.ReadLine();
        List<string> fileLines = new List<string>();

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                fileLines.Add(line);
            }
        }

        List<string> result = new List<string>();
        StringBuilder word = new StringBuilder();
        char lastChar = fileLines[0][0];

        for (int i = 0; i < fileLines.Count; i++)
        {
            for (int j = 0; j < fileLines[i].Length; j++)
            {
                if (lastChar == '>' && fileLines[i][j] != '<')
                {
                    while (j + 1 <= fileLines[i].Length && fileLines[i][j] != '<' )
                    {
                        word.Append(fileLines[i][j]);
                        j++;
                    }

                    result.Add(word.ToString());
                    word.Clear();
                }
                if (j == fileLines[i].Length)
                {
                    lastChar = fileLines[i][j-1];
                }
                else
                {
                    lastChar = fileLines[i][j];
                }
            }

            lastChar = fileLines[i][fileLines[i].Length-1];
        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
