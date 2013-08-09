/* Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. */

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        int bitStart = 3;
        int bitPositionBegining;
        int bitPositionEnd = 24;

        Console.WriteLine("Start number in binary code: {0}", Convert.ToString(number,2).PadLeft(32, '0'));

        for (bitPositionBegining = bitStart; bitPositionBegining < bitStart + 3; bitPositionBegining++)
        {
            int mask = 1 << bitPositionBegining;
            int bitBegining = (mask & number) >> bitPositionBegining; // value of the bit at the begining positions 3,4,5
            mask = 1 << bitPositionEnd;
            int bitEnd = (mask & number) >> bitPositionEnd; // value of the bit at the end positions 24,25, 26
            
            if (bitBegining == 0)
            {
                mask = ~ (1 << bitPositionEnd);
                number = mask & number;
            }

            else if (bitBegining == 1)
            {
                mask = 1 << (bitPositionEnd);
                number = mask | number;
            }

            if (bitEnd == 0)
            {
                mask = ~(1 << bitPositionBegining);
                number = mask & number;
            }

            else if (bitEnd == 1)
            {
                mask = 1 << bitPositionBegining;
                number = mask | number;
            }

            bitPositionEnd ++;
         }

        Console.WriteLine("\nYour new number is: {0}", number);
        Console.WriteLine("New number in binary code: {0}\n", Convert.ToString(number, 2).PadLeft(32, '0'));
        
    }
}

