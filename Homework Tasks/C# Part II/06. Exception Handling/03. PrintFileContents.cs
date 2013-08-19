/* Write a program that enters file name along with its full file path 
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
 * Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible 
 * exceptions and print user-friendly error messages. */

using System;
using System.IO;
using System.Security;


class PrintFileContents
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter the full path to your file:");
                string path = Console.ReadLine();
                Console.WriteLine(File.ReadAllText(path));
                return;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Incorrect path");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
            }
            catch (UnauthorizedAccessException accessEx)
            {
                Console.WriteLine(accessEx.Message);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Your path is in an invalid format");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Your don't have the required permission");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters");
            }
        }
    }
}
