/* Modify your last program (Ex.) and try to make it work for any number type, 
 * not just integer (e.g. decimal, float, byte, etc.). 
 * Use generic method (read in Internet about generic methods in C#).*/

using System;

class GenericMethods
{
    static void Main()
    {
        Console.WriteLine("Minimun number = {0}", Min(-6.6, 4, -6, 0, 34, 10));
        Console.WriteLine("Maximum number = {0}", Max(1, 4m, -6m, 0.7m, 3m, 10));
        Console.WriteLine("Average = {0: 0.00}", Average(1, 4.5f, -6.4f, 0, 34, 10));
        Console.WriteLine("Sum = {0}", Sum(-6.6, 4, -6, 0, 34, 10));
        Console.WriteLine("Product = {0}", Product(1, 4, -6.6, 5.3, 3, 2));
    }

    static T Product<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }

    static double Average<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        double average = Convert.ToDouble(sum) / array.Length;
        return average;
    }

    static T Sum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static T Max<T>(params T[] array)
    {
        dynamic max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }

        return max;
    }

    static T Min<T>(params T[] array)
    {
        dynamic min = array[0];
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