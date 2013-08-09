/* Create a program that assigns null values to an integer and to double variables. 
   Try to print them on the console, try to add some values or the null literal to them and see the result. */

using System;

class NullValueToIntAndDouble
{
    static void Main()
    {
        int? intValue = null;
        double? doubleValue = null;

        Console.WriteLine("intValue = _{0}_, doubleValue = _{1}_\n", intValue, doubleValue);
        
        Console.WriteLine("intValue = _{0}_, doubleValue = _{1}_\n", intValue + null, doubleValue + 2.34);

        intValue = 5;
        doubleValue = 2.56;

        Console.WriteLine("intValue = _{0}_, doubleValue = _{1}_\n", intValue + null, doubleValue + null);
    }
}

