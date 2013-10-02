using System;
using System.Collections.Generic;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main()
        {
            List<int> valley = ReadListOfIntegers(Console.ReadLine());
            int numberOfPatterns = int.Parse(Console.ReadLine());

            List<List<int>> allPaterns = new List<List<int>>(numberOfPatterns);

            for (int i = 0; i < numberOfPatterns; i++)
            {
                allPaterns.Add(ReadListOfIntegers(Console.ReadLine()));
            }

            List<int> initialValley = new List<int>();
            foreach (var item in valley)
            {
                initialValley.Add(item);
            }

            int finalResult = int.MinValue;            

            for (int i = 0; i < numberOfPatterns; i++)
            { 
                int countCoins = ProcessValley(valley, allPaterns[i]);

                if (finalResult < countCoins)
                {
                    finalResult = countCoins;
                }

                valley.Clear();
                foreach (var item in initialValley)
                {
                    valley.Add(item);
                }
            }

            Console.WriteLine(finalResult);
            
        }

        public static int ProcessValley(List<int> valley, List<int> pattern) 
        {
            int valleyPosition = 0;
            var countCoins = valley[valleyPosition];
            valley[valleyPosition] = 0;

            while (true)
            {
                for (int i = 0; i < pattern.Count; i++)
                {
                    int nextValleyPosition = valleyPosition + pattern[i];

                    if (nextValleyPosition >= valley.Count || nextValleyPosition < 0 || valley[nextValleyPosition] == 0)
                    {
                        return countCoins;
                    }
                    else
                    {
                        countCoins += valley[nextValleyPosition];
                        valley[nextValleyPosition] = 0;
                        valleyPosition = nextValleyPosition;
                    }
                }
            }
        }

        public static List<int> ReadListOfIntegers(string input)
        {
            string[] arrayString = new string[input.Length];

            arrayString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> array = new List<int>();

            for (int i = 0; i < arrayString.Length; i++)
            {
                array.Add(int.Parse(arrayString[i]));
            }
            return array;
        }
    }
}
