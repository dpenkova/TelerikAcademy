/* Write a program that reads two numbers N and K and generates 
 * all the combinations of K distinct elements from the set [1..N]. 
 * Example:
	N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, 
 * {2, 5}, {3, 4}, {3, 5}, {4, 5} */

using System;

class CombinationsOfKDistinctElements
{
    static int n;
    static int k;
    static int[] array;

    static void Var(int currentIndex, int startNum)
    {
        if (currentIndex == array.Length)
        {
            Print(array);
        }
        else
        {
            for (int i = startNum; i <= n; i++)
            {
                array[currentIndex] = i;
                startNum++;
                Var(currentIndex + 1, startNum);
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

        Var(0, 1);
    }
}
