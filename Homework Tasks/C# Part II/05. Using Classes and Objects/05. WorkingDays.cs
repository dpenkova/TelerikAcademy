/* Write a method that calculates the number of workdays between today 
* and given date, passed as parameter. Consider that workdays are all days 
* from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;

class WorkingDays
{
    // This will work correctly till the end of 2013, if you add official holydays and working weekends for other years it will work as well
    static DateTime[] publicHolydays = new DateTime[]
            {
                new DateTime(2013, 01, 01),
                new DateTime(2013, 03, 03),
                new DateTime(2013, 05, 01),
                new DateTime(2013, 05, 02),
                new DateTime(2013, 05, 03),
                new DateTime(2013, 05, 04),
                new DateTime(2013, 05, 05),
                new DateTime(2013, 05, 06),
                new DateTime(2013, 05, 24),
                new DateTime(2013, 09, 06),
                new DateTime(2013, 09, 22),
                new DateTime(2013, 12, 24),
                new DateTime(2013, 12, 25),
                new DateTime(2013, 12, 26),
                new DateTime(2013, 12, 31),
            };

    static DateTime[] officialWorkingWeekendDays = new DateTime[]
            {
                new DateTime(2013, 05, 18),
                new DateTime(2013, 12, 14),
            };

    static void Main()
    {
        Console.Write("Enter one future date: ");
        DateTime givenDate = DateTime.Parse(Console.ReadLine());

        //Console.WriteLine((givenDate.Date - DateTime.Now.Date).Days);

        int workingDays = CountWorkingDays(givenDate);
        Console.WriteLine(workingDays);

        Main();
    }

    private static int CountWorkingDays(DateTime givenDate)
    {
        int daysDiff = (givenDate.Date - DateTime.Now.Date).Days;

        int weekendCounter = 0;
        int publicHolydayCounter = 0;
        int officialWorkingWeekendDaysCounter = 0;

        for (int i = 1; i <= daysDiff; i++)
        {
            DateTime currDate = DateTime.Now.AddDays(i);

            if (currDate.DayOfWeek.ToString() == "Saturday" || currDate.DayOfWeek.ToString() == "Sunday")
            {
                weekendCounter++;
            }
            else
            {
                for (int j = 0; j < publicHolydays.Length; j++)
                {
                    if (currDate.Date == publicHolydays[j].Date)
                    {
                        publicHolydayCounter++;
                        break;
                    }
                }
            }

            for (int k = 0; k < officialWorkingWeekendDays.Length; k++)
            {
                if (currDate.Date == officialWorkingWeekendDays[k].Date)
                {
                    officialWorkingWeekendDaysCounter++;
                    break;
                }
            }
        }

        daysDiff = daysDiff - weekendCounter - publicHolydayCounter + officialWorkingWeekendDaysCounter;
        
        return daysDiff;
    }
}
