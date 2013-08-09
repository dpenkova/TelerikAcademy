/* * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer. */

using System;

    class ExchangeBits_Second
    {
        static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter number p: ");
        int bitStart = int.Parse(Console.ReadLine());

        int bitPositionBegining;

        Console.Write("Enter number q: ");
        int bitPositionEnd = int.Parse(Console.ReadLine()); ;

        Console.Write("Enter number k: ");
        int repetitionK = int.Parse(Console.ReadLine());

        Console.WriteLine("Start number in binary code: {0}", Convert.ToString(number,2).PadLeft(32, '0'));

        for (bitPositionBegining = bitStart; bitPositionBegining < bitStart + repetitionK; bitPositionBegining++)
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
