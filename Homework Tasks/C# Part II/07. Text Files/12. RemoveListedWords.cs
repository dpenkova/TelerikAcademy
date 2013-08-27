/* Write a program that removes from a text file all words listed in 
 * given another text file. Handle all possible exceptions in your methods. */

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class RemoveListedWords
{
    static void Main()
    {
        Console.WriteLine("Enter the file name and path where your list is kept: ");
        string listPath = Console.ReadLine();

        Console.WriteLine("Enter the file name and path for the file to clean: ");
        string path = Console.ReadLine();

        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines(listPath)) + @")\b";

            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(Path.GetDirectoryName(path) + "\\temp.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(Regex.Replace(line, regex, String.Empty, RegexOptions.IgnoreCase));
                    }
                }
            }

            File.Delete(path);
            File.Move(Path.GetDirectoryName(path) + @"\temp.txt", path);

            Console.WriteLine("Ready!");
        }
        catch (RegexMatchTimeoutException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (OutOfMemoryException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (ObjectDisposedException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }
}