/* * We are given an array of integers and a number S. 
 * Write a program to find if there exists a subset of the elements 
 * of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6) */

using System;
using System.Collections.Generic;

    class SubsetSumS
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

            List<List<int>> foundSubsets = new List<List<int>>();
            int numberOfAllSubsets = 1;
            for (int i = 0; i < array.Length; i++)
            {
                numberOfAllSubsets *= 2;
            }
            numberOfAllSubsets--;

            for (int s = 1; s <= numberOfAllSubsets; s++)
            {
                long subsetSum = 0;
                List<int> subsetList = new List<int>();

                for (int i = 0; i < array.Length; i++)
                {
                    int bitValue = (s & (1 << i)) >> i;
                    if (bitValue == 1 )
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
            Console.WriteLine("{0} subsets with sum {1} found!", foundSubsets.Count, searchedSum);
            foreach (var subset in foundSubsets)
            {
                Console.Write("yes (");
                for (int i = 0; i < subset.Count; i++)
                {
                    Console.Write("{0}{1}", subset[i], i == subset.Count - 1 ? ")" : "+");
                }
                Console.WriteLine();
            }
            //Console.WriteLine(numberOfAllSubsets);
            Main();
        }
    }