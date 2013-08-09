/* Write a program that reads a positive integer number N (N < 20) from console and outputs 
 * in the console the numbers 1 ... N numbers arranged as a spiral.
		Example for N = 4
 * 
 * 1  2  3  4
 * 12 13 14 5
 * 11 16 15 6
 * 10 9  8  7
 */

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter one integer 0 < N < 20: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int row = 0;
        int col = -1;

        string direction = "right";

        Console.WriteLine();

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right")
            {
                if (++col < n && matrix[row, col] == 0)
                {
                    matrix[row, col] = i;
                }
                else
                {
                    direction = "down";
                    col--;
                }
            }
            if (direction == "down")
            {
                if (++row < n && matrix[row, col] == 0)
                {
                    matrix[row, col] = i;
                }
                else
                {
                    direction = "left";
                    row--;
                }
            }
            if (direction == "left")
            {
                if (--col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = i;
                }
                else
                {
                    direction = "up";
                    col++;
                }
            }
            if (direction == "up")
            {
                if (--row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = i;
                }
                else
                {
                    direction = "right";
                    row++;
                    i--;
                }
            }
        }
        for (int r = 0; r < matrix.GetLongLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLongLength(1); c++)
            {
                Console.Write("{0,4}", matrix[r, c]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
