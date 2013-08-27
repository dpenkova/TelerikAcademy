/* Modify the solution of the previous problem to replace only whole words (not substrings).*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWords
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
                    line = Regex.Replace(line, @"\bstart\b", "finish", RegexOptions.IgnoreCase);

                    //line = Regex.Replace(line, @"\bfinish\b", "start", RegexOptions.IgnoreCase);

                    writer.WriteLine(line);
                }
            }
        }

        File.Delete(path);
        File.Move(Path.GetDirectoryName(path) + @"\temp.txt", path);

        Console.WriteLine("Ready!");
    }
}