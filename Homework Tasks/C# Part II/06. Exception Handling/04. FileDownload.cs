/* Write a program that downloads a file from Internet 
* (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
* Find in Google how to download files in C#. Be sure to catch all exceptions 
* and to free any used resources in the finally block. */

using System;
using System.Net;
using System.IO;

class FileDownload
{
    static void Main()
    {
        Console.WriteLine("Enter the full URL path for the file which you want to download:\nExample: http://www.devbg.org/img/Logo-BASD.jpg");
        
        string destination = Directory.GetCurrentDirectory();
        WebClient webClient = new WebClient();

        while (true)
        {
            try
            {
                Uri siteUri = new Uri(Console.ReadLine());
                string fileName = Path.GetFileName(siteUri.LocalPath); // gets the file name with extension

                webClient.DownloadFile(siteUri, fileName);
                Console.WriteLine("\nFile successfully downloaded to:\n{0}\n", destination);
                return;
            }
            catch (System.UriFormatException)
            {
                Console.WriteLine("Invalid or empty URL.\nTry again: ");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid adress or empty file.\nTry again: ");
            }
            catch (NotSupportedException notSupportedEx)
            {
                Console.WriteLine(notSupportedEx.Message);
                Console.WriteLine("Try again: ");
            }
            catch (ArgumentNullException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }
}
