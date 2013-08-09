/* Write a program, that reads from the console an array of N integers 
 * and an integer K, sorts the array and using the method Array.BinSearch() 
 * finds the largest number in the array which is ≤ K. */

using System;

namespace ArrayBinSearch
{
    class ArrayBinSearch
    {
        static void Main()
        {
            Console.Write("Enter one positive integer for the length of your array or 0 for auto generation: ");
            int n = int.Parse(Console.ReadLine());
            int[] array;
            if (n == 0)
            {
                Random rand = new Random();
                n = rand.Next(9, 15);
                array = new int[n];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-10, 10);
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

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}{1}", array[i], i == array.Length - 1 ? "" : ", ");
            }
            Console.WriteLine();

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}{1}", array[i], i == array.Length - 1 ? "" : ", ");
            }
            Console.WriteLine();

            Console.Write("Enter the searched number K = ");
            int numberK = int.Parse(Console.ReadLine());

            int result = Array.BinarySearch(array, numberK);

            if (result >= 0)
            {
                Console.WriteLine("The largest number in the array which is <= {0} is: {1}, on index {2}", numberK, array[result], result);
            }
            else
            {
                if (~result <= 0)
                {
                    Console.WriteLine("The is no such a number in your array!");
                }
                else
                {
                    Console.WriteLine("The largest number in the array which is <= {0} is: {1}, on index {2}", numberK, array[(~result) - 1], (~result) - 1);
                }
            }
            Main();
        }
    }
}
