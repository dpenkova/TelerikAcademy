/* We are given integer number n, value v (v=0 or 1) and a position p. 
   Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
   Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	         n = 5 (00000101), p=2, v=0 -> 1 (00000001) */

using System;

class AssignValueToAGivenPosition
{
    static void Main()
    {
        Console.Write("Enter your number N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter the new bit value V (0 or 1): ");
        int valueV = int.Parse(Console.ReadLine());
        Console.Write("Enter the new bit position P: ");
        int positionP = int.Parse(Console.ReadLine()); ;
        int result = 0;

        int mask = 1 << positionP;

        if (valueV == 1)
        {
            result = numberN | mask;
            Console.WriteLine("\nYour new number is: {0}",result);
        }
        else if (valueV == 0)
        {
            result = (~mask) & numberN;
            Console.WriteLine("\nYour new number is: {0}",result);
        }

        else
        {
            Console.WriteLine("\nIncorrect value of V!\n");
        }
    }
}

