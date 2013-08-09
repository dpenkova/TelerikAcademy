/* Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5} */

using System;

    class SequenceOfGivenSum
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

            Console.Write("Enter the searched sum: ");
            int searchedSum = int.Parse(Console.ReadLine());
            
            bool isSumPresent = false;
            int sum = 0;

            Console.WriteLine("Result:");
            for (int j = 0; j < array.Length; j++)
            {
                sum = 0;
                for (int i = j; i < array.Length; i++)
                {
                    sum += array[i];

                    if (sum == searchedSum)
                    {
                        isSumPresent = true;
                        Console.Write("{");
                        for (int k = j; k <= i; k++)
                        {
                            if (k == i)
                            {
                                Console.WriteLine("{0}}}", array[k]);
                            }
                            else
                            {
                                Console.Write("{0}, ", array[k]);
                            }
                        }
                    }
                }
            }
            if (!isSumPresent)
            {
                Console.WriteLine("None of the elements compose the searched sum.");
            }
            Main();
        }
    }
