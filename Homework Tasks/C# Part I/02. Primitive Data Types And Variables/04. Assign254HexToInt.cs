/* Declare an integer variable and assign it with the value 254 in hexadecimal format. 
 * Use Windows Calculator to find its hexadecimal representation. */

using System;

class Assign254HexToInt
{
    static void Main()
    {
       int intNumber = 0xFE;
        
       Console.WriteLine("{0} is {1:X} in hexadecimal format.\n", intNumber, intNumber);
    }
}

