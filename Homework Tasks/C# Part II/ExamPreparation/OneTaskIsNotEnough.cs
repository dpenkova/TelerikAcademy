// 04 Feb 2013 - Solution by the video

using System;

class OneTaskIsNotEnough
{
    static void Main()
    {
        int numberOfLamps = int.Parse(Console.ReadLine());
        string pathOne = Console.ReadLine();
        string pathTwo = Console.ReadLine();

        Console.WriteLine(Task1(numberOfLamps));

        //task 2
        Console.WriteLine(Task2(pathOne));
        Console.WriteLine(Task2(pathTwo));

    }

    static int Task1(int countOff)
    {
        bool[] turnOnNow = new bool[countOff + 1];
        int[] lampsStillOff = new int[countOff + 1];

        int lastLamp = 0;

        for (int i = 1; i <= countOff; i++)
        {
            lampsStillOff[i] = i;
        }

        int jump = 1;
        while (countOff > 0)
        {
            jump++;
            Array.Clear(turnOnNow, 1, countOff);

            for (int i = 1; i <= countOff; i += jump)
            {
                turnOnNow[i] = true;
            }

            int newCountOff = 0;
            for (int i = 1; i <= countOff; i++)
            {
                if (!turnOnNow[i])
                {
                    newCountOff++;
                    lampsStillOff[newCountOff] = lampsStillOff[i];
                    lastLamp = lampsStillOff[i];
                }
            }

            countOff = newCountOff;
        }

        return lastLamp;
    }

    static string Task2(string commands)
    {
        //string commands = Console.ReadLine();

        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };

        int x = 0;
        int y = 0;
        int orientation = 0;

        for (int i = 0; i < 4; i++)
        {
            foreach (var command in commands)
            {
                if (command == 'S')
                {
                    x += dx[orientation];
                    y += dy[orientation];
                }
                else if (command == 'L')
                {
                    orientation -= 1;
                    orientation += 4;
                    orientation %= 4;
                }
                else if (command == 'R')
                {
                    orientation += 1;
                    orientation %= 4;
                }
            }
        }

        if (x == 0 && y == 0)
        {
            return ("bounded");
        }
        else
        {
            return ("unbounded");
        }
    }
}