/* Write a program that reads a text file containing a square matrix of numbers 
* and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
* The first line in the input file contains the size of matrix N. Each of the next N lines contain 
* N numbers separated by space. The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4			17
3 7 1 2
4 3 3 2
*/

using System;
using System.IO;
using System.Linq;
using System.Text;

class ReadAMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter your file path and name: ");

        using (StreamReader reader = new StreamReader(Console.ReadLine()))
        {
            int arrSize = int.Parse(reader.ReadLine());
            int[,] arr = new int [arrSize, arrSize];

            ReadArray(reader, arrSize, arr);
            int maxSum = GetMax2X2Sum(arr);

            Console.WriteLine("Enter the result file name and path: ");
            using (StreamWriter writer = new StreamWriter(Console.ReadLine()))
            {
                writer.Write(maxSum);
            }
        }
    }

    private static int GetMax2X2Sum(int[,] arr)
    {
        int maxSum = 0;
        int currentSum = 0;

        for (int r = 0; r < arr.GetLength(0) - 1; r++)
        {
            for (int c = 0; c < arr.GetLength(1) - 1; c++)
            {
                currentSum = arr[r, c] + arr[r + 1, c] + arr[r, c + 1] + arr[r + 1, c + 1];

                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    currentSum = 0;
                }
            }
        }
        return maxSum;
    }

    private static void ReadArray(StreamReader reader, int arrSize, int[,] arr)
    {
        for (int i = 0; i < arrSize; i++)
        {
            string line = reader.ReadLine();

            for (int j = 0; j < arrSize; j++)
            {
                StringBuilder number = new StringBuilder();

                for (int index = 0; index < line.Length; index++)
                {
                    if (line[index] != ' ')
                    {
                        number.Append(line[index]);
                    }
                    else
                    {
                        arr[i, j] = int.Parse(number.ToString());
                        j++;
                        number.Clear();
                    }
                }
                if (number != null)
                {
                    arr[i, j] = int.Parse(number.ToString());
                    number.Clear();
                }
            }
        }
    }
}