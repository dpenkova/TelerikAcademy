using System;
using System.Collections.Generic;

namespace IEnumerableExtensions
{
    class ConsoleTest
    {
        static void Main()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<double> doubleList = new List<double> { 1.5, 2.5, 3.5, 4.5 };
            List<float> floatList = new List<float> { 1.5f, 2.5f, 3.5f, 4.5f };
            int[] intArr = new int[] { 1, 2, 3, 4, 5, 6 };

            //IEnumerableExtensions.Sum<int>(null);
            
            Console.WriteLine(intList.Sum<int>());
            Console.WriteLine(doubleList.Sum<double>());
            Console.WriteLine(floatList.Sum<float>());
            Console.WriteLine(intArr.Sum<int>());

            Console.WriteLine();

            Console.WriteLine(intList.Product<int>());
            Console.WriteLine(doubleList.Product<double>());
            Console.WriteLine(floatList.Product<float>());
            Console.WriteLine(intArr.Product<int>());

            Console.WriteLine();

            Console.WriteLine(intList.Min<int>());
            Console.WriteLine(doubleList.Min<double>());
            Console.WriteLine(floatList.Min<float>());
            Console.WriteLine(intArr.Min<int>());

            Console.WriteLine();

            Console.WriteLine(intList.Max<int>());
            Console.WriteLine(doubleList.Max<double>());
            Console.WriteLine(floatList.Max<float>());
            Console.WriteLine(intArr.Max<int>());

            Console.WriteLine();

            Console.WriteLine(intList.Average<int>());
            Console.WriteLine(doubleList.Average<double>());
            Console.WriteLine(floatList.Average<float>());
            Console.WriteLine(intArr.Average<int>());  
         }
    }
}
