/* Write an expression that extracts from a given integer i the value of a given bit number b. 
 * Example: i=5; b=2 -> value=1. */

using System;

    class BitAtPositionB
    {
        static void Main()

        {
            int intNumberi = int.Parse(Console.ReadLine());
            int positionB = int.Parse(Console.ReadLine());

            int mask = 1 << positionB;
            int numberiAndPosition = intNumberi & mask;
            mask = numberiAndPosition >> positionB;

            Console.WriteLine("{0}", mask);
        }
    }

