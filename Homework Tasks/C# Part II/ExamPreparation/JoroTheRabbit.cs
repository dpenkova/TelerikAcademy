using System;

class JoroTheRabbit
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char [] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

        int[] path = new int [input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            path[i] = int.Parse(input[i]);
        }

        int bestPath = 0;

        for (int i = 0; i < path.Length; i++)
        {
            for (int step = 1; step < path.Length; step++)
            {
                int currentPosition = i;
                int nextPosition = currentPosition + step;
                if (nextPosition >= path.Length)
                {
                    nextPosition -= path.Length;
                }
                int currentPath = 1;

                while (path[nextPosition] > path[currentPosition])
                {
                    currentPath++;

                    currentPosition = nextPosition;

                    nextPosition = currentPosition + step;
                    if (nextPosition >= path.Length)
                    {
                        nextPosition -= path.Length;
                    }
                }

                if (bestPath < currentPath)
                {
                    bestPath = currentPath;
                }
            }
        }

        Console.WriteLine(bestPath);
    }
}
