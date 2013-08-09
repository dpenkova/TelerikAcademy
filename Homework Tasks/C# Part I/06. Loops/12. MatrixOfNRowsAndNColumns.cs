/* 12. Write a program that reads from the console a positive integer number N (N < 20) 
 * and outputs a matrix like the following:
 * 
 * Example: 
 * 1 2 3 4
 * 2 3 4 5
 * 3 5 6 7
 * 4 5 6 7
 */

using System;

class MatrixOfNRowsAndNColumns
{
    static void Main()
    {
        Console.Write("Enter a integer 0 < N < 20, N = ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0 || n > 20 )
        {
            Console.WriteLine("Your number is out of scope");
        }
        else
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < row + n; col++)
                {
                    Console.Write("{0,3}", col);
                }
                Console.WriteLine();
            }
        }
    }
}
