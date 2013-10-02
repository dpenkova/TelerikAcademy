// 06 Feb 2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Stars3D
{
    private static int width, height, depth, starCount;
    private static char[, ,] cube;
    private static Dictionary<char, int> starType = new Dictionary<char, int>();

    static void Main()
    {
        ReadInput();
        FindStars();
        PrintResult();
    }

    private static void PrintResult()
    {
        var sortedResult = starType.OrderBy(x => x.Key);    // сортира по Key има го и за масиви и други колекции, може да сортира и по двете полета пр. starType.OrderBy(x => x.Key).ThenBy(x => x.Value);  
        Console.WriteLine(starCount);

        foreach (var star in sortedResult)
        {
            Console.WriteLine("{0} {1}", star.Key, star.Value);
        }
    }

    private static void FindStars()
    {
        for (int w = 1; w < width - 1; w++)
        {
            for (int h = 1; h < height - 1; h++)
            {
                for (int d = 1; d < depth - 1; d++)
                {
                    FindSingleStar(w, h, d);
                }
            }
        }
    }
  
    private static void FindSingleStar(int currentWidth, int currentHeight, int currentDepth)
    {
        char currentChar = cube[currentWidth, currentHeight, currentDepth];

        bool isStar = currentChar == cube[currentWidth - 1, currentHeight, currentDepth] &&
                    currentChar == cube[currentWidth + 1, currentHeight, currentDepth] &&
                    currentChar == cube[currentWidth, currentHeight - 1, currentDepth] &&
                    currentChar == cube[currentWidth, currentHeight + 1, currentDepth] &&
                    currentChar == cube[currentWidth, currentHeight, currentDepth - 1] &&
                    currentChar == cube[currentWidth, currentHeight, currentDepth + 1];

        if (isStar)
        {
            starCount++;

            if (starType.ContainsKey(currentChar))   // съдържа ли вече този ключ
            {
                starType[currentChar]++;
            }
            else
            {
                starType.Add(currentChar, 1);       // ако го няма добави го със стойност 1
            }
        }
    }

    private static void ReadInput()
    {
        string[] cubeDimensions = Console.ReadLine().Split();
        width = int.Parse(cubeDimensions[0]);
        height = int.Parse(cubeDimensions[1]);
        depth = int.Parse(cubeDimensions[2]);

        cube = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] lineDepthParts = Console.ReadLine().Split();

            for (int d = 0; d < depth; d++)
            {
                string contentWidthParts = lineDepthParts[d]; // съдържанието на всяко кубче в куба

                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = contentWidthParts[w];
                }
            }

        }
    }
}
