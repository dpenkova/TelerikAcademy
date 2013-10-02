// 07 Feb 2012

using System;

class Slices3D
{
    private static int width, height, depth, result, wholeCubeSum;
    private static int[, ,] cube;

    static void Main()
    {
        ReadInput();

        CalculateWholeCubeSum();

        CalculateSlicesWidth();
        CalculateSlicesHeight();
        CalculateSlicesDepth();

        Console.WriteLine(result);
    }

    private static void CalculateWholeCubeSum()
    {
        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    wholeCubeSum += cube[w, h, d];
                }
            }
        }
    }

    private static void CalculateSlicesWidth()
    {
        int currentSlicesSum = 0;

        for (int w = 0; w < width - 1; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    currentSlicesSum += cube[w, h, d];
                }
            }

            if (currentSlicesSum == wholeCubeSum - currentSlicesSum)
            {
                result++;
            }
        }
    }

    private static void CalculateSlicesHeight()

    {
        int currentSlicesSum = 0;

        for (int h = 0; h < height - 1; h++)
        {
            for (int w = 0; w < width; w++)
            {
                for (int d = 0; d < depth; d++)
                {
                    currentSlicesSum += cube[w, h, d];
                }
            }

            if (currentSlicesSum == wholeCubeSum - currentSlicesSum)
            {
                result++;
            }
        }
    }

    private static void CalculateSlicesDepth()
    {
        int currentSlicesSum = 0;

        for (int d = 0; d < depth - 1; d++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    currentSlicesSum += cube[w, h, d];
                }
            }

            if (currentSlicesSum == wholeCubeSum - currentSlicesSum)
            {
                result++;
            }
        }
    }

    private static void ReadInput()
    {
        string[] dimensions = Console.ReadLine().Split();
        width = int.Parse(dimensions[0]);
        height = int.Parse(dimensions[1]);
        depth = int.Parse(dimensions[2]);

        cube = new int [width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] depths = Console.ReadLine().Split(new char [] {'|'}, StringSplitOptions.RemoveEmptyEntries);

            for (int d = 0; d < depth; d++)
            {
                string[] cubeElements = depths[d].Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = int.Parse(cubeElements[w]);
                }
            }
        }
    }
}
