using System;
using System.Linq;

// Task 06 - Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


namespace DivisibleBy3And7
{
    class DivisibleBy3And7
    {
        static void Main()
        {
            int[] array = new int[] { 1, 3, 5, 7, 21, 63, 15, 147, 12, 49, 0 };


            // using Lambda expressions

            var lambdaQry = array.Where( x => (x % 3 == 0) && (x % 7 == 0));

            foreach (var num in lambdaQry)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            // using LINQ

            var linqQry =
                from num in array
                where num % 3 == 0 && num % 7 == 0
                select num;

            foreach (var num in linqQry)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
