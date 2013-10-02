// Exam 06 Feb 2012

using System;

class Tubes
{
    static void Main()
    {
        long initialNumberOfTubes = long.Parse(Console.ReadLine());
        long neededTubes = long.Parse(Console.ReadLine());

        long[] sizes = new long[initialNumberOfTubes];
        long maxSized = 0;

        for (int i = 0; i < sizes.Length; i++)
        {
            sizes[i] = long.Parse(Console.ReadLine());

            if (maxSized < sizes[i])
            {
                maxSized = sizes[i];
            }
        }

        // binary search
        long startSizeRange = 1;
        long endSizeRange = maxSized;
        long middle = (startSizeRange + endSizeRange) / 2;
        long result = -1;
        
        while (startSizeRange <= endSizeRange) 
        {
            long reachedLength = 0;

            for (int i = 0; i < sizes.Length; i++)
            {
                reachedLength += sizes[i] / middle; 
            }

            if (reachedLength < neededTubes)
            {
                endSizeRange = middle - 1;
            }
            else if (reachedLength >= neededTubes)
            {
                startSizeRange = middle + 1;
                result = middle;
            }

            middle = (startSizeRange + endSizeRange) / 2;
        }

        Console.WriteLine(result);
    }
}