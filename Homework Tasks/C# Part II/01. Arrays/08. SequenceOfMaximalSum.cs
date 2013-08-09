/* Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)? */

using System;

    class SequenceOfMaximalSum
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

            //print the matrix 
            foreach (var item in array)
	        {
		         Console.Write("{0, 2} |", item);
	        }
            Console.WriteLine();

            int maxSum = int.MinValue;
            int lastIndex = 0;
            int firstIndex = 0;
            int sum = 0;

            for (int j = 0; j < array.Length; j++)
            {
                sum = 0;
                for (int i = j; i < array.Length; i++)
                {
                    sum += array[i];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        firstIndex = j;
                        lastIndex = i;
                    }
                }
            }

            Console.Write("Result: \n{");
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                if (i == lastIndex)
                {
                    Console.WriteLine("{0}}}", array[i]);
                }
                else
                {
                    Console.Write("{0}, ", array[i]);
                }
            }
            Console.WriteLine("Max sum: {0}", maxSum);
            Console.WriteLine("Start index: {0}", firstIndex);
            Console.WriteLine("End index: {0}", lastIndex);
            
            Main();
        }
    }