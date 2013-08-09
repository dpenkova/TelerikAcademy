/* We are given a matrix of strings of size N x M. Sequences in the matrix 
 * we define as sets of several neighbor elements located on the same line, 
 * column or diagonal. Write a program that finds the longest sequence of 
 * equal strings in the matrix. Example:
 * 
 * ha  fifi ho  hi          s  qq s
 * fo  ha   hi  xx          pp pp s
 * xxx ho   ha  xx          pp qq s
 * 
 * ha, ha, ha               s, s, s
*/

using System;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        string[,] matrix = 
        {
            {"xx", "xyx", "xx", "xox", "xex", "xx"},
            {"fif", "yy", "fofi", "ho", "fo", "mi"},
            {"xxx", "bu", "yy", "fifi", "gy", "mm"},
            {"xx", "ffi", "bb", "yy", "ky", "mim"},
            {"xxx", "fii", "xx", "bu", "gy", "mm"},
        };

        //// Enter the matrix from the console
        //Console.Write("Enter one integer for the number of rows: ");
        //int rowsNumber = int.Parse(Console.ReadLine());
        //Console.Write("Enter one integer for the number of columns: ");
        //int colsNumber = int.Parse(Console.ReadLine());

        //string[,] matrix = new string[rowsNumber, colsNumber];

        //Console.WriteLine("Enter the elements of your matrix: ");

        //for (int r = 0; r < matrix.GetLength(0); r++)
        //{
        //    for (int c = 0; c < matrix.GetLength(1); c++)
        //    {
        //        Console.Write("[{0}, {1}] = ", r, c);
        //        matrix[r, c] = Console.ReadLine();
        //    }
        //}

        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write("{0, 5}", matrix[r, c]);
            }
            Console.WriteLine();
        }

        int bestSequenceLength = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            int sequenceLength = 1;

            for (int c = 0; c < matrix.GetLength(1) - 1; c++)
            {
                if (matrix[r, c] == matrix[r, c + 1])
                {
                    sequenceLength++;
                }
                else
                {
                    if (sequenceLength > bestSequenceLength)
                    {
                        bestSequenceLength = sequenceLength;
                        bestRow = r;
                        bestCol = c;
                        sequenceLength = 1;
                    }
                    else
                    {
                        sequenceLength = 1;
                    }

                }

                if (sequenceLength > bestSequenceLength)
                {
                    bestSequenceLength = sequenceLength;
                    bestRow = r;
                    bestCol = c + 1;
                }
            }
        }

        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            int sequenceLength = 1;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                if (matrix[r, c] == matrix[r + 1, c])
                {
                    sequenceLength++;
                }
                else
                {
                    if (sequenceLength > bestSequenceLength)
                    {
                        bestSequenceLength = sequenceLength;
                        bestRow = r;
                        bestCol = c;
                        sequenceLength = 1;
                    }
                    else
                    {
                        sequenceLength = 1;
                    }
                }

                if (sequenceLength > bestSequenceLength)
                {
                    bestSequenceLength = sequenceLength;
                    bestRow = r + 1;
                    bestCol = c;
                }
            }
        }

        // diagonal right part one
        for (int r = matrix.GetLength(0) - 2; r >= 0; r--)
        {
            int sequenceLength = 1;
            int cc = 0;
            for (int rr = r; rr < matrix.GetLength(0) - 1; rr++, cc++)
            {
                if (cc + 1 == matrix.GetLength(1))
                {
                    break;
                }
                else
                {
                    if (matrix[rr, cc] == matrix[rr + 1, cc + 1])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        if (sequenceLength > bestSequenceLength)
                        {
                            bestSequenceLength = sequenceLength;
                            bestRow = rr;
                            bestCol = cc;
                            sequenceLength = 1;
                        }
                        else
                        {
                            sequenceLength = 1;
                        }
                    }

                    if (sequenceLength > bestSequenceLength)
                    {
                        bestSequenceLength = sequenceLength;
                        bestRow = rr + 1;
                        bestCol = cc + 1;
                    }
                }
            }
        }

        // diagonal right second part
        for (int c = 1; c < matrix.GetLength(1) - 1; c++)
        {
            int sequenceLength = 1;
            int cc = c;
            for (int r = 0; r < matrix.GetLength(0) - 1; r++, cc++)
            {
                if (cc + 1 == matrix.GetLength(1))
                {
                    break;
                }
                else
                {
                    if (matrix[r, cc] == matrix[r + 1, cc + 1])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        if (sequenceLength > bestSequenceLength)
                        {
                            bestSequenceLength = sequenceLength;
                            bestRow = r;
                            bestCol = cc;
                            sequenceLength = 1;
                        }
                        else
                        {
                            sequenceLength = 1;
                        }
                    }

                    if (sequenceLength > bestSequenceLength)
                    {
                        bestSequenceLength = sequenceLength;
                        bestRow = r + 1;
                        bestCol = cc + 1;
                    }
                }
            }
        }

        // left diagonal bottom part
        for (int c = 0; c < matrix.GetLength(1) - 1; c++)
        {
            int sequenceLength = 1;
            int cc = c;
            for (int r = matrix.GetLength(0) - 1; r > 0; r--, cc++)
            {
                if (cc + 1 == matrix.GetLength(1))
                {
                    break;
                }
                else
                {
                    if (matrix[r, cc] == matrix[r - 1, cc + 1])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        if (sequenceLength > bestSequenceLength)
                        {
                            bestSequenceLength = sequenceLength;
                            bestRow = r;
                            bestCol = cc;
                            sequenceLength = 1;
                        }
                        else
                        {
                            sequenceLength = 1;
                        }
                    }

                    if (sequenceLength > bestSequenceLength)
                    {
                        bestSequenceLength = sequenceLength;
                        bestRow = r - 1;
                        bestCol = cc + 1;
                    }
                }
            }
        }

        // left diagonal upper part
        for (int r = matrix.GetLength(0) - 2; r >= 0; r--)
        {
            int sequenceLength = 1;
            int cc = 0;
            for (int rr = r; rr > 0; rr--, cc++)
            {
                if (cc + 1 == matrix.GetLength(1))
                {
                    break;
                }
                else
                {
                    if (matrix[rr, cc] == matrix[rr - 1, cc + 1])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        if (sequenceLength > bestSequenceLength)
                        {
                            bestSequenceLength = sequenceLength;
                            bestRow = rr;
                            bestCol = cc;
                            sequenceLength = 1;
                        }
                        else
                        {
                            sequenceLength = 1;
                        }
                    }

                    if (sequenceLength > bestSequenceLength)
                    {
                        bestSequenceLength = sequenceLength;
                        bestRow = rr - 1;
                        bestCol = cc + 1;
                    }
                }
            }
        }
        Console.Write("\nLongest sequence is: ");
        for (int i = 0; i < bestSequenceLength - 1; i++)
        {
            Console.Write("{0}, ", matrix[bestRow, bestCol]);
        }
        Console.WriteLine(matrix[bestRow, bestCol]);
    }
}
