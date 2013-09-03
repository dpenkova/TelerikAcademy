/* Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
 * and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
 */

using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        //string url = @"http://www.devbg.org/forum/index.php";

        Console.Write("Enter URL: ");
        string url = Console.ReadLine();

        string pattern = @"(?<protocol>(.+))://(?<server>(.+?))/(?<resource>(.*))";

        if (Regex.IsMatch(url, pattern))
        {
            var matches = Regex.Match(url, pattern).Groups;

            Console.WriteLine("[Protocol]: \"{0}\"", matches["protocol"].Value);
            Console.WriteLine("[Server]:   \"{0}\"", matches["server"].Value);
            Console.WriteLine("[Resource]: \"{0}\"", matches["resource"].Value);
        }
        else
        {
            Console.WriteLine("Invalid URL");
        }
    }
}