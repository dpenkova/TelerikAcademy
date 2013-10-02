// 04 Feb 2013

using System;
using System.Linq;


class Slides3D
{
    private static int width, height, depth, ballW, ballD, ballH, oldBallW, oldBallH, oldBallD;
    private static string[, ,] cube;

    static void Main()
    {
        ReadInput();
        ProceedBallCommands();
    }

    private static void ProceedBallCommands()
    {
        while (true)
        {
            string currentCell = cube[ballW, ballH, ballD];

            string[] splitedCell = currentCell.Split();

            string command = splitedCell[0];

            switch (command)
            {
                case "S":
                    ProcessBallSlides(splitedCell[1]);
                    break;
                case "T":
                    ballW = int.Parse(splitedCell[1]);
                    ballD = int.Parse(splitedCell[2]);
                    break;
                case "B":
                    PrintMessage();
                    return;
                case "E":
                    if (ballH == height - 1)
                    {
                        PrintMessage();
                        return;
                    }
                    else
                    {
                        ballH++;
                    }
                    break;

                default: throw new ArgumentException("Invalid command");
                    break;
            }
        }
    }

    private static void ProcessBallSlides(string command)
    {
        oldBallW = ballW;
        oldBallH = ballH;
        oldBallD = ballD;

        switch (command)
        {
            case "R":       // ако е R, увеличва ширината width + 1
                ballH++;    // по условие при "S" минава на по-долно ниво -> heihg + 1
                ballW++; 
                break;
            case "L":       // ако е L, намалява по ширината width - 1
                ballH++;
                ballW--;  
                break;
            case "F":       // ако е F, намалява по дълбочина depth - 1
                ballH++;
                ballD--;
                break;
            case "B":       // ако е B, увеличава по дълбочина depth + 1
                ballH++;
                ballD++;
                break;
            case "FL":
                ballH++;
                ballD--;
                ballW--;
                break;
            case "FR":
                ballH++;
                ballD--;
                ballW++;
                break;
            case "BL":
                ballH++;
                ballD++;
                ballW--; 
                break;
            case "BR":
                ballH++;
                ballD++;
                ballW++;
                break;

            default: throw new ArgumentException("Invalid slide command");
                break;
        }

        if (!IsPassabe(ballW, ballH, ballD))
        {
            ballW = oldBallW;
            ballH = oldBallH;
            ballD = oldBallD;

            PrintMessage();
            Environment.Exit(0); // спира изпълнението на цялата програма
        }
    }

    private static void PrintMessage()
    {
        string currentCell = cube[ballW, ballH, ballD];

        if (currentCell == "B" || ballH != height - 1)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }

        Console.WriteLine("{0} {1} {2}", ballW, ballH, ballD);
    }

    private static bool IsPassabe(int ballW, int ballH, int ballD)
    {
        if (ballW >= 0 && ballH >= 0 && ballD >= 0 && ballW < width && ballH < height && ballD < depth)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    private static void ReadInput()
    {
        string[] dimensions = Console.ReadLine().Split();

        width = int.Parse(dimensions[0]);
        height = int.Parse(dimensions[1]);
        depth = int.Parse(dimensions[2]);

        cube = new string [width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] depths = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            for (int d = 0; d < depth; d++)
            {
                string[] cubesValues = depths[d].Split(new char[] { ')', '(' }, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = cubesValues[w];
                }
            }
        }

        string[] ballStartPositions = Console.ReadLine().Split();
        ballW = int.Parse(ballStartPositions[0]);
        ballH = 0;
        ballD = int.Parse(ballStartPositions[1]);
    }
}
