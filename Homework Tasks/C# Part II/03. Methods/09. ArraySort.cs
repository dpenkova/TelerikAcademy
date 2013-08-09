/* Write a method that returns the maximal element in a portion of array of integers 
 * starting at given index. Using it write another method that sorts an array 
 * in ascending / descending order.*/

using System;

class ArraySort
{
    static void Main()
    {
        int[] array = CreateAnArray();
        PrintArray(array);

        Console.Write("Enter the starting index: ");
        int givenIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("The maximal element for you selection, index [{0} - {1}], is: {2}", givenIndex,  array.Length - 1, MaxElement(array, givenIndex));
        Console.WriteLine();

        Console.Write("Choose how to sort your array (\"Ascending\" or \"Descending\"): ");
        string sortOrder = (Console.ReadLine()).ToLower();
        Console.WriteLine();

        Console.WriteLine("Your sorted array:");
        PrintArray(SortArray(array, sortOrder));
        
        Main();
    }

    static int[] SortArray(int[] arr, string order)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int maxEl = MaxElement(arr, i);
            int maxIndex = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] == maxEl)
                {
                    maxIndex = j;
                    break;
                }
            }
            arr[maxIndex] = arr[i];
            arr[i] = maxEl;
        }

        if (order == "ascending")
        {
            Array.Reverse(arr);
        }

        return arr;
    }

    static int MaxElement(int[] arr, int startIndex)
    {
        int maxIndex = startIndex;
        for (int i = startIndex + 1; i < arr.Length; i++)
        {
            if (arr[maxIndex] < arr[i])
            {
                maxIndex = i;
            }
        }
        return arr[maxIndex];
    }

    static void PrintArray(int[] arrayName)
    {
        for (int i = 0; i < arrayName.Length; i++)
        {
            Console.Write("{0} ", arrayName[i]);
        }
        Console.WriteLine();
    }

    static int[] CreateAnArray()
    {
        Console.WriteLine(new string('=', 15));
        Console.Write("Enter the length of your array or 0 for autogeneration: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] array;

        if (arrLength == 0)
        {
            Random rand = new Random();
            array = new int[rand.Next(9, 19)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }
        }
        else
        {
            array = new int[arrLength];
            Console.WriteLine("Enter your array elements:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        return array;
    }
}