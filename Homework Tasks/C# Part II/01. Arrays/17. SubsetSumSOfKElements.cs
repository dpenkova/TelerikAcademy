/*  * Write a program that reads three integer numbers N, K and S 
* and an array of N elements from the console. Find in the array 
* a subset of K elements that have sum S or indicate about its absence. */

using System;
using System.Collections.Generic;

class SubsetSumSOfKElements
{
    static void Main()
    {
        Console.Write("Enter one positive integer for the length of your array or 0 for auto generation: ");
        int n = int.Parse(Console.ReadLine());
        int[] array;
        if (n == 0)
        {
            Random rand = new Random();
            n = rand.Next(9, 15);
            array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
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

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}{1}", array[i], i == array.Length - 1 ? "" : ", ");
        }
        Console.WriteLine();

        Console.Write("Enter the searched subset sum, S = ");
        int searchedSum = int.Parse(Console.ReadLine());

        Console.Write("Enter the searched subset elements, K = ");
        int K = int.Parse(Console.ReadLine());

        List<List<int>> foundSubsets = new List<List<int>>();
        int numberOfAllSubsets = 1;
        for (int i = 0; i < array.Length; i++)
        {
            numberOfAllSubsets *= 2;
        }
        numberOfAllSubsets--;

        for (int s = 1; s <= numberOfAllSubsets; s++)
        {
            string stringOfS = Convert.ToString(s, 2);
            int countBits = 0;
            for (int j = 0; j < stringOfS.Length; j++)
            {
                if (Convert.ToInt32(new string(stringOfS[j], 1)) == 1)
                {
                    countBits++;
                }
            }
            if (countBits == K)
            {
                long subsetSum = 0;
                List<int> subsetList = new List<int>();

                for (int i = 0; i < array.Length; i++)
                {
                    int bitValue = (s & (1 << i)) >> i;
                    if (bitValue == 1)
                    {
                        subsetSum += array[i];
                        subsetList.Add(array[i]);
                    }
                }
                if (subsetSum == searchedSum)
                {
                    foundSubsets.Add(subsetList);
                }
            }
        }
        Console.WriteLine("{0} subsets of {2} elements with sum {1} found!", foundSubsets.Count, searchedSum, K);
        foreach (var subset in foundSubsets)
        {
            Console.Write("(");
            for (int i = 0; i < subset.Count; i++)
            {
                Console.Write("{0}{1}", subset[i], i == subset.Count - 1 ? ")" : "+");
            }
            Console.WriteLine();
        }
        Main();
    }
}
