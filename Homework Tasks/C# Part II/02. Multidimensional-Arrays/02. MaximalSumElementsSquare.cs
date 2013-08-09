/* Write a program that reads a rectangular matrix of size N x M 
 * and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;

class MaximalSumElementsSquare
{
    static void Main()
    {
        Random rand = new Random();
        int numberOfRows;
        int numberOfColumns;
        int[,] matrix;

        Console.Write("Enter 0 for automatic creation of your matrix, or number of rows N:  ");
        numberOfRows = int.Parse(Console.ReadLine());

        if (numberOfRows == 0)
        {
            numberOfRows = rand.Next(5, 15);
            numberOfColumns = rand.Next(5, 15);
            matrix = new int[numberOfRows, numberOfColumns];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rand.Next(1, 99);
                }
            }
        }
        else
        {
            Console.Write("Enter the number of columns: ");
            numberOfColumns = int.Parse(Console.ReadLine());
            matrix = new int[numberOfRows, numberOfColumns];

            Console.WriteLine("Enter the matrix elements:");
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("[{0}, {1}] = ", r, c);
                    matrix[r, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        PrintMatrix(matrix);

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int r = 0; r < matrix.GetLength(0) - 2; r++)
        {
            for (int c = 0; c < matrix.GetLength(1) - 2; c++)
            {
                int sum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2]
                        + matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2]
                        + matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = r;
                    bestCol = c;
                }
            }
        }

        Console.WriteLine("Best sum is: {0}, starting at row {1} and col {2}.", bestSum, bestRow, bestCol);

        for (int r = bestRow; r < bestRow + 3; r++)
        {
            for (int c = bestCol; c < bestCol + 3; c++)
            {
                Console.Write("{0, 5}", matrix[r, c]);
            }
            Console.WriteLine();
        }
        Main();
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write("{0, 5}", matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}
