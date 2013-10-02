// 05 Feb 2013

using System;
//using System.Collections.Generic;
//using System.Linq;
using System.IO;
//using System.Text;
//using System.Threading.Tasks;


class Laser
{
    static void Main()
    {
        if (File.Exists("input.txt"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        int[] dimensions = ReadInput();
        int[] laserPosition = ReadInput();
        int[] vectorDirections = ReadInput();

        bool[,,] visitedCells = new bool[dimensions[0] + 1, dimensions[1] + 1, dimensions[2] + 1];

        while (true)
        {
            visitedCells[laserPosition[0], laserPosition[1], laserPosition[2]] = true;

            int[] newLaserPosition = new int[3];
            for (int i = 0; i < newLaserPosition.Length; i++)
            {
                newLaserPosition[i] = laserPosition[i] + vectorDirections[i];
            }

            if (visitedCells[newLaserPosition[0], newLaserPosition[1], newLaserPosition[2]] == true || 
                CountLimitIndexes(newLaserPosition, dimensions) >= 2)
            {
                // next position is visited -> end
                Console.WriteLine("{0} {1} {2}", laserPosition[0], laserPosition[1], laserPosition[2]);
                return;
            }

            if (CountLimitIndexes(newLaserPosition, dimensions) == 1)
            {
                // we've hit a wall
                ReverseVectorComponent(newLaserPosition, vectorDirections, dimensions);
            }

            for (int i = 0; i < laserPosition.Length; i++)
            {
                laserPosition[i] = newLaserPosition[i];
            }
        }
    }

    private static void ReverseVectorComponent(int[] newLaserPosition, int[] vectorDirections, int[] dimensions)
    {
        for (int i = 0; i < newLaserPosition.Length; i++)
        {
            if (newLaserPosition[i] == 1 && vectorDirections[i] == -1)
            {
                vectorDirections[i] *= -1;
            }
            else if (newLaserPosition[i] == dimensions[i] && vectorDirections[i] == 1)
            {
                vectorDirections[i] *= -1;
            }
        }
    }

    private static int CountLimitIndexes(int[] laserPosition, int[] dimensions)
    {
        int count = 0;
        for (int i = 0; i < laserPosition.Length; i++)
        {
            if (laserPosition[i] == 1 || laserPosition[i] == dimensions[i])
            {
                count++;   // count += 1;
            }
        }

        return count;
    }

    private static int[] ReadInput()
    {
        string[] splitedValues = Console.ReadLine().Split();

        //return splitedValues.Select(s => int.Parse(s)).ToArray();

        int[] array = new int[3];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(splitedValues[i]);
        }

        return array;
    }
}
