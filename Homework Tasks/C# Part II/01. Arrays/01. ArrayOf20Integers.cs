/* Write a program that allocates array of 20 integers and initializes each 
 * element by its index multiplied by 5. Print the obtained array on the console. */

using System;

    class ArrayOf20Integers
    {
        static void Main()
        {
            int[] Matrix = new int[20];

            for (int i = 1; i <= Matrix.Length; i++)
            {
                Matrix[i-1] = i * 5;
            }

            foreach (var item in Matrix)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }