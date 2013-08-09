/* Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}. */

using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer for the length of your array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            if (arrayLength == 0)
            {
                Console.WriteLine("Your array length is invalid! Try again."); Main();
            }
            else
            { 
                Console.WriteLine("Enter your array elements");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0,2} =  ", i);
                    array[i] = int.Parse(Console.ReadLine());
                }
            }

            ////print the array
            //foreach (var item in array)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.WriteLine();

            if (arrayLength == 1)
            {
                Console.WriteLine(array[0]);
            }
            else
            {
                int sequenceLenght = 1;
                int maxSequenceLength = 1;
                int startIndex = 0;
                int[,] results = new int[2, arrayLength]; // create a matrix to collect count results
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
                        Console.Write("{");
                        for (int j = results[0, i]; j <= results[0, i] + results[1, i] - 1; j++)
                        {
                            if (j == results[0, i] + results[1, i] - 1)
                            {
                                Console.Write("{0}", array[j]);
                            }
                            else
                            {
                                Console.Write("{0},", array[j]);
                            }
                        }
                        Console.WriteLine("}");
                    }
                }
                Main();
            }
        }
    }