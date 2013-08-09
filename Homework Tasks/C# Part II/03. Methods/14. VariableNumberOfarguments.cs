/* Write methods to calculate minimum, maximum, average, sum and product of 
* given set of integer numbers. Use variable number of arguments.*/

using System;

class VariableNumberOfarguments
{
    static void Main()
    {
        Console.WriteLine("Minimun number = {0}", Min(1, 4, -6, 0, 34, 10));
        Console.WriteLine("Maximum number = {0}", Max(1, 4, -6, 0, 34, 10));
        Console.WriteLine("Average = {0: 0.00}", Average(1, 4, -6, 0, 34, 10));
        Console.WriteLine("Sum = {0}", Sum(1, 4, -6, 0, 34, 10));
        Console.WriteLine("Product = {0}", Product(1, 4, -6, 0, 34, 10));
    }

    static int Product(params int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }

    static double Average(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        double average = (double)sum / array.Length;
        return average;
    }

    static int Sum(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static int Max(params int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }

        return max;
    }

    static int Min(params int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }

        return min;
    }
}
