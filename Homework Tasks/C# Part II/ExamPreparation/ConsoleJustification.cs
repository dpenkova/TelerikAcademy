using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConsoleJustification
{
    static void Main()
    {
        int linesNumber = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        StringBuilder input = new StringBuilder();

        for (int i = 0; i < linesNumber; i++)
        {
            input.Append(Console.ReadLine() + " ");
        }

        string [] textWords = input.ToString().Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);


        // split to output lines
        StringBuilder line = new StringBuilder(20);
        List<string> outputLines = new List<string>();

        int index = 0;

        while (index < textWords.Length)
        {
            for (; index < textWords.Length; index++)
            {
                if (line.Length + textWords[index].Length  <= width)
                {
                    line.Append(textWords[index] + " ");
                }
                else
                {
                    outputLines.Add(line.ToString());
                    line.Clear();
                    break;
                }
            }
        }
        outputLines.Add(line.ToString());
        line.Clear();

        //// trim the last ' ' from each output line

        for (int l = 0; l < outputLines.Count; l++)
        {
            string currentLine = outputLines[l];

            if (currentLine[currentLine.Length - 1] == ' ')
            {
                StringBuilder trimEnd = new StringBuilder();
                for (int i = 0; i < currentLine.Length - 1; i++)
                {
                    trimEnd.Append(currentLine[i]);
                }
                outputLines[l] = trimEnd.ToString();
            }
        }

        // process justification
        for (int l = 0; l < outputLines.Count; l++)
        {
            string currentLine = outputLines[l];

            string[] wordsInLine = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int countWords = wordsInLine.Length;

            if (countWords > 1)
            {
                int countSpaces = countWords - 1;
                int spacesToAdd = width - currentLine.Length;
                int gapSize = spacesToAdd / countSpaces;
                int additionalWhiteSpacesNeeded = spacesToAdd % countSpaces;

                StringBuilder outputLine = new StringBuilder();

                for (int i = 0; i < wordsInLine.Length - 1; i++)
                {
                    outputLine.Append(wordsInLine[i]);
                    outputLine.Append(new string(' ', gapSize + 1));

                    if (additionalWhiteSpacesNeeded > 0)
                    {
                        outputLine.Append(' ');
                        additionalWhiteSpacesNeeded--;
                    }
                }
                outputLine.Append(wordsInLine[wordsInLine.Length - 1]);

                outputLines[l] = outputLine.ToString();
            }
        }

        // print the result
        foreach (var item in outputLines)
        {
            Console.WriteLine(item);
        }
    }
}