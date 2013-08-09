/* You are given an array of strings. Write a method that sorts the array 
 * by the length of its elements (the number of characters composing them). */

using System;

    class SortArrayLengthOfElements
    {
        static void Main(string[] args)
        {

            Console.Write("Enter one numbe for the lenght of your array: ");
            int inputN = int.Parse(Console.ReadLine());

            string[] array = new string [inputN];

            Console.WriteLine("Enter the elements of your array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0, 3} = ", i);
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("Original array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            SortArray(array);

            Console.WriteLine("Array sorted by the length of its elements:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
        }

        private static void SortArray(string[] array)
        {
            Array.Sort(array, (a, b) => a.Length.CompareTo(b.Length));
        }
    }
