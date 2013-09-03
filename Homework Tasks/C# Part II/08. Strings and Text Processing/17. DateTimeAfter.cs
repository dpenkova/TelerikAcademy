/* Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
 * and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

using System;
using System.Globalization;

class DateTimeAfter
{
    static void Main()
    {
        //Console.WriteLine("Enter date and time (day.month.year hour:minute:second): ");
        //DateTime input = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        DateTime input = DateTime.Now;
        Console.WriteLine("{0:d.M.yyyy HH:mm:ss }", input);
        DateTime output = input.AddHours(6.5);
        Console.WriteLine("{0:d.M.yyyy hh:mm:ss}, {1}", output, output.ToString("dddd", new CultureInfo("bg-BG")));
    }
}