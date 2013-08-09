/* Write a program that sorts an array of strings using the quick 
 * sort algorithm (find it in Wikipedia).*/

using System;

    class QuickSort
    {
        static int n;
        static int[] array;

        static void Main()
        {
            Console.Write("Enter one positive integer for the length of your array or 0 for auto generation: ");
            n = int.Parse(Console.ReadLine());
            
            if (n == 0)
            {
                Random rand = new Random();
                n = rand.Next(5, 15 );
                array = new int[n];
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

            foreach (var item in array)
            {
                Console.Write("{0,3} ", item);                
            }
            Console.WriteLine();

            int j = array.Length - 1;
            
            int start = 0;

            sort(start, j);

            foreach (var item in array)
            {
                Console.Write("{0,3} ", item);
            }
            Console.WriteLine();
            Main();
        }

        static void sort (int start, int j)
        {
                int index = start + 1;
                int end = j;
                if (start >= j)
                {
                    return;
                }
            while (index < j)
            {
                if (array[index] > array[start])
                {
                    while (array[j] > array[start])
                    {
                        if (j > start)
                        {
                            j--;
                        }
                        else break;
                    }
                    if (j == start || j < index)
                    {
                        break;
                    }
                    else
                    {
                        int temp = array[j];
                        array[j] = array[index];
                        array[index] = temp;
                        if (j > start)
                        {
                            j--;
                        }
                    }
                }
                index++;
            }
            while (array[j] > array[start])
            {
                j--;
            }
            int temp1 = array[j];
            array[j] = array[start];
            array[start] = temp1;

            sort(start, j - 1);
            sort(j + 1, end);
        }  
    }
