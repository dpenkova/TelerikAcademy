/*Write a program that reads two numbers N and K and generates 
 * all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, 
 * {2, 3}, {3, 1}, {3, 2}, {3, 3} */

using System;

class VariationsOfKElements
{
    static int n;
    static int k;
    static int[] array;

    static void Var(int currentIndex)
    {
        if (currentIndex == array.Length)
        {
            Print(array);
        }
        else 
        {
            for (int i = 1; i <= n; i++)
            {
                array[currentIndex] = i;
                Var(currentIndex + 1);
            }
        }
    }

    static void Print(int[] array)
    {
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}{1}", array[i], i == array.Length - 1 ? "}" : ", ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("N = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        k = int.Parse(Console.ReadLine());

        array = new int[k];

        Var(0);
    }
}