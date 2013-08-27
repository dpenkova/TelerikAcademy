/* Write a program that reads a list of words from a file words.txt and finds how many times 
 * each of the words is contained in another file test.txt. The result should be written in 
 * the file result.txt and the words should be sorted by the number of their occurrences 
 * in descending order. Handle all possible exceptions in your methods.*/

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class CountRepetitions
{
    static void Main()
    {
        try 
        {
            Console.WriteLine("Enter you list file name and path:");
            string[] searchedWords = File.ReadAllLines(Console.ReadLine());

            int[] counter = new int [searchedWords.Length];

            Console.WriteLine("Enter the name and path for the file to look in:");
            string path = Console.ReadLine();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < searchedWords.Length; i++)
                    {
                        counter[i] += Regex.Matches(line, @"\b(" + searchedWords[i] + @")\b", RegexOptions.IgnoreCase).Count;
                    }
                }
            }

            Array.Sort(counter, searchedWords);

            using (StreamWriter writer = new StreamWriter(Path.GetDirectoryName(path) + @"\result.txt"))
            {
                for (int i = counter.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine("{0}: {1}", searchedWords[i], counter[i]);
                }
 
            }

            Console.WriteLine("Ready! Your results file is: {0}", Path.GetDirectoryName(path) + @"\result.txt");
        }

        catch (FileNotFoundException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (IOException ex)
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
        catch (OutOfMemoryException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (RegexMatchTimeoutException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (ObjectDisposedException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (SecurityException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }
}
