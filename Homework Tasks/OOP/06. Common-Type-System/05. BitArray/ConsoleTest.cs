using System;

namespace BitArray
{
    class ConsoleTest
    {
        static void Main()
        {
            BitArray64 someNumber = new BitArray64(239);

            int[] bitsArray = someNumber.ValueBits;

            for (int i = 0; i < bitsArray.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, bitsArray[i]); 
            }
            Console.WriteLine();

            Console.WriteLine("Enumerator test: "); 
            foreach (var item in someNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("Indexer test:");
            Console.WriteLine("index 0: {0}", someNumber[0]);
            Console.WriteLine("index 7: {0}", someNumber[7]);
            Console.WriteLine("index 63: {0}", someNumber[63]);

        }

    }
}
