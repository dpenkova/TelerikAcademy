/* Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly. */

using System;

public class CountNumber
{
    public static void Main()
    {
        int[] array = CreateAnArray();
        PrintArray(array);

        Console.Write("Enter the number to count repetitions: ");
        int searchedNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Your number {0} appears {1} times in your array.", searchedNumber, CountRepetitions(array, searchedNumber));
    }

    public static int CountRepetitions(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
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
