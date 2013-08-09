/* Declare  two integer variables and assign them with 5 and 10 and after that exchange their values. */

using System;

class Exchange2IntValues
{
    static void Main()
    {
        int value1 = 5;
        int value2 = 10;
        int temp = value1;

        Console.WriteLine("Initially\n value 1 is: {0}\n and\n value 2 is: {1}\n", value1, value2);

        value1 = value2;
        value2 = temp;

        Console.WriteLine("After the exchange\n value 1 is: {0}\n and\n value 2 is: {1}\n\n", value1, value2);

        // Second way to do it, without a temp variable

        int numberOne = 5;
        int numberTwo = 10;

        Console.WriteLine("Result fron the second way:\n");
        Console.WriteLine("Initially\n value 1 is: {0}\n and\n value 2 is: {1}\n", numberOne, numberTwo);

        numberOne = numberOne + numberTwo;
        numberTwo = numberOne - numberTwo;
        numberOne = numberOne - numberTwo;

        Console.WriteLine("After the exchange\n value 1 is: {0}\n and\n value 2 is: {1}\n", numberOne, numberTwo);
    }
}

