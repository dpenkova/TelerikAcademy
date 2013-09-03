/* Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
 * Display them in the standard date format for Canada.*/

using System;
using System.Text.RegularExpressions;
using System.Globalization;

class ExtractDates
{
    static void Main()
    {
        string input = @"26.07.1945,88.10.2312, 11MAY200050.13.2012 Monnday, 08.05.1945  31/10/19715.02.2004, 04/04/2003 06.08.1945; 3-05-1974,April 9, 1977 Nov. 12, 2423 04/12/1324"" 12.10.2012zvczb26.07.1945, 40i9u85 09-23-133 13 April 2013, 34/23/03,09.08.1945 15.08.1942,:08.15.2012;;05-May-2020";
        string pattern = @"\d{1,2}[\.|/]\d{1,2}(\.|[/])\d{4}";
        //string pattern = @"(\d{2}\.){2}\d{4}";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (var match in matches)
        {
            DateTime date;

            if (DateTime.TryParse(match.ToString(), out date))
            {
                Console.WriteLine(date.ToString(new CultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}