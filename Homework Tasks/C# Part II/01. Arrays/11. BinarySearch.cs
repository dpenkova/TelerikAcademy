/* Write a program that finds the index of given element in a sorted array 
 * of integers by using the binary search algorithm (find it in Wikipedia).*/

using System;

    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Enter one positive integer for the length of your array or 0 for auto generation: ");
            int n = int.Parse(Console.ReadLine());
            int[] array;
            if (n == 0)
            {
                Random rand = new Random();
                n = rand.Next(1,100);
                array = new int [n];
                for (int i = 0; i < array.Length; i++)
			    {
			     array[i] = rand.Next(-100, 100);
			    }
            }
            else
            {
                array = new int[n];
                for (int i = 0; i < array.Length; i++)
			    {
			        Console.Write("{0} = ", i);
                    array[i] = int.Parse(Console.ReadLine());
			    }
            }
            Array.Sort(array);
            Console.WriteLine("Your sorted array is:");
            foreach (var item in array)
            {
                Console.Write("{0,3} |", item);
            }
            Console.WriteLine();

            Console.WriteLine("Enter the searched element: ");
            int SearchedElement = int.Parse(Console.ReadLine());
            int minIndex = 0;
            int maxIndex = n - 1;
            int midIndex = (minIndex + maxIndex) / 2;
            bool isPresent = false;

            while (maxIndex >= minIndex)
            {
                midIndex = (minIndex + maxIndex) / 2;
                if (array[midIndex] > SearchedElement)
                {
                    maxIndex = midIndex - 1;
                }
                else if (array[midIndex] < SearchedElement)
                {
                    minIndex = midIndex + 1;
                }
                else
                {
                    Console.WriteLine("Your searched element {0} index is: {1}", SearchedElement, midIndex);
                    isPresent = true;
                    break;
                }
            }
            if (!isPresent)
            {
                Console.WriteLine("The searched element {0} is not present in the current array.", SearchedElement);
            }
            Main();
        }
    }
