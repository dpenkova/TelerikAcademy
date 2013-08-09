/* Write a method that returns the index of the first element in array that is 
 * bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise. */

using System;

class IndexOfTheFirstBiggerElement
{
    static void Main()
    {
        int[] array = CreateAnArray();
        PrintArray(array);
        PrintIndexOfFirstBiggerElement(array);
        Main();
    }

    static void PrintIndexOfFirstBiggerElement(int[] array)
    {
        if (array.Length > 1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (IsBigger(i, array))
                {
                    Console.WriteLine("Index of the first element ({1}) bigger than its neighbors is {0}", i, array[i]);
                    return;
                }
            }
            Console.WriteLine("-1: No such element found!");
        }
        else
        {
            Console.WriteLine("-1: No such element found!");
        }
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
