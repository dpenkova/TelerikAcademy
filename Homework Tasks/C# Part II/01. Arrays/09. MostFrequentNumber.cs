/* Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times) */

using System;

    class MostFrequentNumber
    {
        static void Main()
        {
            Console.Write("Enter one positive integer for the length of your array: ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrLength];

            // fill the array with random elements
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }

            ////Fill the matrix with your own elements
            //Console.WriteLine("Enter your array elements:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("{0} = ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //print the array 
            foreach (var item in array)
            {
                Console.Write("{0, 2} |", item);
            }
            Console.WriteLine();

            Array.Sort(array);
            //print sorted array 
            Console.WriteLine("Sorted array: ");
            foreach (var item in array)
            {
                Console.Write("{0, 2} |", item);
            }
            Console.WriteLine();

            int sequenceLenght = 1;
            int maxSequenceLength = 1;
            int startIndex = 0;
            int[,] results = new int[2, arrLength]; // create a matrix to collect count results
            int col = 0;

            for (int i = 1; i < array.Length; i++)
            {

                if (array[i - 1] == array[i])
                {
                    sequenceLenght++;
                    results[0, col] = startIndex;
                    results[1, col] = sequenceLenght;
                }
                else
                {
                    if (i == 1)
                    {
                        results[0, col] = startIndex;
                        results[1, col] = sequenceLenght;
                        col++;
                        startIndex = i;
                        results[0, col] = startIndex;
                        results[1, col] = sequenceLenght;
                    }
                    else
                    {
                        col++;
                        sequenceLenght = 1;
                        startIndex = i;
                        results[0, col] = startIndex;
                        results[1, col] = sequenceLenght;
                    }
                }
            }

            //// print stored values, row 0 - holding starting index, row 1 - holding sequence length
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < results.GetLength(1); j++)
            //    {
            //        Console.Write("{0} ", results[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            // get the max sequence lenght from the stored values
            for (int i = 0; i < results.GetLength(1); i++)
            {
                if (results[1, i] > maxSequenceLength)
                {
                    maxSequenceLength = results[1, i];
                }
            }

            // print the results, all the max sequences
            for (int i = 0; i < results.GetLength(1); i++)
            {
                if (results[1, i] == maxSequenceLength)
                {
                    Console.WriteLine("{0} ({1} times)", array[results[0, i]], results[1, i]);
                }
            }
            Main();
        }
    }
