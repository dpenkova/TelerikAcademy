/*Sorting an array means to arrange its elements in increasing order. 
 * Write a program to sort an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first position, find the smallest from the rest, 
 * move it at the second position, etc.*/

using System;

class SelectionSortAlgorithm
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
            array[i] = rnd.Next(-100, 100);
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
            Console.Write("{0, 4} |", item);
        }
        Console.WriteLine();

        // Selection sort

        int minIndex = 0;
        int temp = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }

        // Buuble sort
        //int temp = 0;
        //for (int j = 0; j < array.Length; j++)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (i + 1 < array.Length && array[i] > array[i + 1])
        //        {
        //            temp = array[i];
        //            array[i] = array[i + 1];
        //            array[i + 1] = temp;
        //        }
        //    }
        //}

        foreach (var item in array)
        {
            Console.Write("{0, 4} |", item);
        }
        Console.WriteLine();
        Main();
    }
}
