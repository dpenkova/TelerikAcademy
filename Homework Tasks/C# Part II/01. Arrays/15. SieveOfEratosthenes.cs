/* Write a program that finds all prime numbers in the range [1...10 000 000]. 
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/

using System;

    class SieveOfEratosthenes
    {
        static void Main()
        {
            Console.Write("Enter one positive integer n > 1: ");
            int n = int.Parse(Console.ReadLine());
            DateTime start = DateTime.Now;
            bool[] array = new bool[n+1];
            array[2] = true;
            for (int i = 3; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = false;
                }
                else
                {
                    array[i] = true;
                }
            }
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("{0} = {1}", i, array[i]);
            //}

            int end;
            if (!int.TryParse((Math.Sqrt((double)n).ToString()), out end))
            {
                end = (int)(double)Math.Sqrt(n) + 1;
            }
            
            for (int i = 2; i <= end; i++)
            {
                if (array[i] == true)
                {
                    for (int j = i * i; j < array.Length; j+= i)
                    {
                        array[j] = false;
                    }   
                }
            }
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Executuon time: {0}", DateTime.Now - start);
            Console.WriteLine();
            Main();
        }
    }
