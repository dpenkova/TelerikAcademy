/* Write a program that replaces all occurrences of the substring "start" with the substring "finish" 
 * in a text file. Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.IO;
using System.Linq;

class ReplaceSubstring
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
                while ( (line = reader.ReadLine()) != null)   
                {
                    line = line.Replace("start", "finish");
                    //line = line.Replace("finish", "start");
                    writer.WriteLine(line);
                }
            }
        }

        File.Delete(path);
        File.Move(Path.GetDirectoryName(path) + @"\temp.txt", path);

        Console.WriteLine("Ready!");
    }
}