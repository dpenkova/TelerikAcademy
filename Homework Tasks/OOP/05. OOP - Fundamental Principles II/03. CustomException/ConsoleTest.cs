/*  Task 03:
    Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
It should hold error message and a range definition [start … end].
    Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
 */

using System;

namespace CustomException
{
    class ConsoleTest
    {
        static void Main()
        {
            // Test - entering numbers in the range [1..100] 

            Console.WriteLine("Enter one integer between 1 and 100 :");
            int inputNumber = int.Parse(Console.ReadLine());

            try
            {
                if (inputNumber < 1 || inputNumber > 100)
                {
                    throw new InvalidRangeException<int>("Invalid number!", 0, 100);
                }

                Console.WriteLine("Correct! Number is in the range [1 - 100]");
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine("{0} Value should be in the range [{1} - {2}]", ire.Message, ire.Start, ire.End);
            }

            // Test - dates in the range [1.1.1980 … 31.12.2013]

            Console.WriteLine("Enter one date between 1.1.1980 and 31.12.2013");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            try
            {
                if (inputDate < new DateTime (1980, 1, 1) || inputDate > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Invalid date!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }

                Console.WriteLine("Correct! Your date is in the range [1.1.1980 - 31.12.2013]");
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine("{0}Value should be in the range [{1} to {2}]", ire.Message, ire.Start.ToShortDateString(), ire.End.ToShortDateString());
            }
        }
    }
}
