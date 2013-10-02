// 05 Feb 2013

using System;
using System.IO;

class Laser
{
	private static int width, height, depth, startW, startH, startD,
						dirW, dirH, dirD, newPositionW, newPositionH, newPositionD;
    static void Main()
    {
        if (File.Exists("input.txt"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        int[] dimensions = ReadInput();
		width = dimensions[0];
		height = dimensions[1];
		depth = dimensions[2];
		
        int[] laserPosition = ReadInput();
		startW = laserPosition[0];
		startH = laserPosition[1];
		startD = laserPosition[2];
		
        int[] vectorDirections = ReadInput();
		dirW = vectorDirections[0];
		dirH = vectorDirections[1];
		dirD = vectorDirections[2];

        bool[,,] visitedCells = new bool[width + 1, height + 1, depth + 1];
		
		        while (true)
        {
            visitedCells[startW, startH, startD] = true;
			
			newPositionW = startW + dirW;
			newPositionH = startH + dirH;
			newPositionD = startD + dirD;

            if (visitedCells[newPositionW, newPositionH, newPositionD] == true || 
                CountLimitIndexes(newPositionW, newPositionH, newPositionD) >= 2)  
            {
                // next position is visited -> end
                Console.WriteLine("{0} {1} {2}", startW, startH, startD);
                return;
            }

            if (CountLimitIndexes(newPositionW, newPositionH, newPositionD) == 1)
            {
                // we've hit a wall
                ReverseVectorComponent();
            }

           startW = newPositionW;
		   startH = newPositionH;
		   startD = newPositionD;
        }
    }
	
	 private static void ReverseVectorComponent()
    {
        
            if (newPositionW == 1 && dirW == -1)
            {
                dirW *= -1;
            }
            else if (newPositionW == width && dirW == 1)
            {
                dirW *= -1;
            }
			
			if (newPositionH == 1 && dirH == -1)
            {
                dirH *= -1;
            }
            else if (newPositionH == height && dirH == 1)
            {
                dirH *= -1;
            }
			
			if (newPositionD == 1 && dirD == -1)
            {
                dirD *= -1;
            }
            else if (newPositionD == depth && dirD == 1)
            {
                dirD *= -1;
            }
    }

    private static int CountLimitIndexes(int posW, int posH, int posD)
    {
        int count = 0;
        
            if (posW == 1 || posW == width)
            {
                count++;   
            }
			if (posH == 1 || posH == height)
            {
                count++;   
            }
			if (posD == 1 || posD == depth)
            {
                count++;   
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
