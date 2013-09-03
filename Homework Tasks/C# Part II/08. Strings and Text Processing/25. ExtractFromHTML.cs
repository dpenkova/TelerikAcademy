/* Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
 * Example: 
  <html>
  <head><title>News</title></head>
  <body><p><a href=""http://academy.telerik.com"">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>
 * Result: News
 * Telerik Academy aims to provide free real-world practical training for young people who want to turn into skillful 
 * .NET software engineers. */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractFromHTML
{
    static void Main()
    {
        string input = @"  <html>
                          <head><title>News</title></head>
                          <body><p><a href=""http://academy.telerik.com"">Telerik
                            Academy</a>aims to provide free real-world practical
                            training for young people who want to turn into
                            skillful .NET software engineers.</p></body>
                        </html>";

        string pattern = "<.*?>|\\r\\n";

        string[] matches = Regex.Split(input, pattern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

        StringBuilder output = new StringBuilder();

        foreach (string match in matches)
        {
            if (!String.IsNullOrWhiteSpace(match))
            {
                output.Append(match.Trim());
                output.Append(" ");
            }
        }
       
        Console.WriteLine(output.ToString().Trim());
    }
}