/* Write a program that fills and prints a matrix of size (n, n) as shown below: 
 * (examples for n = 4)
 * a)          b)           c)          d)*
 * 1 5  9 13   1 8  9 16    7 11 14 16  1 12 11 10
 * 2 6 10 14   2 7 10 15    4  8 12 15  2 13 16  9
 * 3 7 11 15   3 6 11 14    2  5  9 13  3 14 15  8
 * 4 8 12 16   4 5 12 13    1  3  6 10  4  5  6  7
 * 
*/

using System;

class FillAndPrintAMatrix
{
    static void Main()
    {
        Console.Write("Enter your number N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int i = 1;

        // Matrix a)
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = i;
                i++;
            }
        }
        Console.WriteLine("Martix a)");
        PrintMatrix(matrix);

        
        // Matrix b)
        i = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = i;
                    i++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = i;
                    i++;
                }
            }
        }
        Console.WriteLine("Martix b)");
        PrintMatrix(matrix);

    // Matrix c)
        i = 1;
        int rowC = matrix.GetLength(0) - 1;
        int colC = 0;
        matrix[rowC, colC] = 1;
        string direction = "up";

        for ( i = 2; i <= n*n ; i++)
        {
            if (direction == "up" && rowC - 1 >= 0)
            {
                rowC--;
                matrix[rowC, colC] = i;
                direction = "down";
            }
            else if (direction == "down" && rowC + 1  < matrix.GetLength(0) && colC + 1 < matrix.GetLength(1))
            {
                rowC++;
                colC++;
                matrix[rowC, colC] = i;
                
                if (rowC == matrix.GetLength(0) - 1 && colC == matrix.GetLength(1) - 1)
                {
                    direction = "up";
                    rowC = 1;
                    colC = 1;
                }
                else if (rowC == matrix.GetLength(0) - 1)
                {
                    direction = "up";
                    rowC -= colC;
                    colC = 0;
                }
                else if (colC == matrix.GetLength(1) - 1)
                {
                    direction = "up";
                    colC = colC - rowC + 1;
                    rowC = 1;
                }
            }
        }
        Console.WriteLine("Martix c)");
        PrintMatrix(matrix);

        // Matrix d)

        for (int row = 0; row < matrix.GetLength(0); row++)
		{
			for (int col = 0; col < matrix.GetLength(1); col++)
			{
			    matrix[row, col] = 0;
			}
		}

        i = 1;
        rowC = 0;
        colC = 0;
        matrix[rowC, colC] = 1;
        direction = "down";

        for ( i = 2; i <= n * n; i++)
        {
            if (direction == "down" && rowC + 1 < matrix.GetLength(0))
            {
                rowC++;
                matrix[rowC, colC] = i;

                if (rowC == matrix.GetLength(0) - 1 || matrix[rowC + 1, colC] != 0)
                {
                    direction = "right";
                }

            }
            else if (direction == "right" && colC + 1 < matrix.GetLength(1))
            {
                colC++;
                matrix[rowC, colC] = i;

                if (colC == matrix.GetLength(1) - 1 || matrix[rowC, colC + 1] != 0)
                {
                    direction = "up";
                }
            }
            else if (direction == "up" && rowC - 1 >= 0)
            {
                rowC--;
                matrix[rowC, colC] = i;

                if (rowC == 0 || matrix[rowC - 1, colC] != 0)
                {
                    direction = "left";
                }
            }
            else if (direction == "left" && matrix[rowC, colC - 1] == 0)
            {
                colC--;
                matrix[rowC, colC] = i;

                if (matrix[rowC, colC - 1] != 0)
                {
                    direction = "down";
                }
            }
        }
        Console.WriteLine("Martix d)");
        PrintMatrix(matrix);
        Main();
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}