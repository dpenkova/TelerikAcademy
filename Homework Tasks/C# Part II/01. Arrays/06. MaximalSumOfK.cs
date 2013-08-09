/*Write a program that reads two integer numbers N and K and an array of N elements 
 * from the console. Find in the array those K elements that have maximal sum.*/

using System;

    class MaximalSumOfK
    {
        static void Main()
        {
            Console.Write("Enter a positive integer for the length of your array: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter one positive integer for the K elements: ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter the elements of your array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int maxSum = 0;
            int[,] results = new int[2, n];  //create a matrix for the results to keep all max sums and their starting index

            for (int i = 0; i <= n - k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    sum = sum + array[i + j];
                }

                results[0, i] = i;
                results[1, i] = sum;

                sum = 0;
            }

            ////print the results matrix
            //for (int row = 0; row < results.GetLength(0); row++)
            //{
            //    for (int col = 0; col < results.GetLength(1); col++)
            //    {
            //        Console.Write("{0,2} |", results[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            // Find the maximal sum, from all the sums stored in the results' matrix
            for (int i = 0; i < results.GetLength(1); i++)
            {
                int row = 1;

                if (results[row, i] > maxSum)
                {
                    maxSum = results[row, i];
                }
            }
            Console.WriteLine("Max sum: {0}", maxSum);

            for (int i = 0; i < results.GetLength(1); i++)
            {
                int row = 0;
                int row1 = 1;

                if (results[row1, i] == maxSum)
                {
                    Console.Write("{");
                    for (int j = results[row, i]; j < results[row, i] + k; j++)
                    {
                        if (j == results[row, i] + k - 1)
                        {
                            Console.Write("{0}", array[j]);
                            Console.WriteLine("}");
                        }
                        else
                        {
                            Console.Write("{0},", array[j]);
                        }
                    }
                }
            }
            Main();
        }
    }