/* Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. */

using System;

class BooleanExpression
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int myNumber = Int32.Parse(Console.ReadLine());

        bool result = (myNumber % 5 == 0 && myNumber % 7 == 0);

        Console.WriteLine("The statement:\n \"The number {0} can be be devided (without remainder) by 7 and 5 in the same time.\" \nis: {1}", myNumber, result);

    }
}
