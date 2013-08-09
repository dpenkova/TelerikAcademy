/* Write a method that checks if the element at given position in given array of integers 
* is bigger than its two neighbors (when such exist).*/ 

using System;

class IsBiggerThanItsTwoNeighbors
{
    static void Main()
    {
        int[] array = CreateAnArray();
        PrintArray(array);

        if (array.Length > 1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0} is bigger than its neighbor {1} : {2}", array[i], array[i + 1], IsBigger(i, array));
                }
                else if (i == array.Length - 1)
                {
                    Console.WriteLine("{0} is bigger than its neighbor {1} : {2}", array[i], array[i - 1], IsBigger(i, array));
                }
                else
                {
                    Console.WriteLine("{0} is bigger than its two neighbors {1} and {2} : {3}", array[i], array[i - 1], array[i + 1], IsBigger(i, array));
                }
            }
        }
        else
        {
            Console.WriteLine("Your array is only of one element, there is nothing to compare!");
        }
        Main();
    }

    static bool IsBigger(int index, int[] array)
    {
        if (index == 0 && index + 1 < array.Length)
        {
            if (array[index] > array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (index == array.Length - 1)
        {
            if (array[index] > array[index - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    static void PrintArray(int[] arrayName)
    {
        for (int i = 0; i < arrayName.Length ; i++)
        {
            Console.Write("{0} ", arrayName[i]);
        }
        Console.WriteLine();
    }

    static int[] CreateAnArray()
    {
        Console.Write("Enter the length of your array or 0 for autogeneration: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] array;

        if (arrLength == 0)
        {
            Random rand = new Random();
            array = new int[rand.Next(7, 15)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
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