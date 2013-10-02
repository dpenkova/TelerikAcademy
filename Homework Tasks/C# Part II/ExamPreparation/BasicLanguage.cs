// 07 Feb 2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BasicLanguage
{
    private static StringBuilder output = new StringBuilder();
    private static List<string> allCommands = new List<string>();
    private static bool exit = false;
    
    static void Main()
    {
        ReadInput();
        ConvertInputToCommands();
        RunCommands();

        Console.WriteLine(output.ToString());
    }

    private static void RunCommands()
    {
        output.Clear();

        for (int i = 0; i < allCommands.Count; i++)
        {
            int allLoops = 1; // брояч за повторенията на даден текст от команда PRINT

            string[] subCommands = allCommands[i].Split(new char [] {')'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var command in subCommands)
            {
                string currentCommand = command.TrimStart();

                if (currentCommand.StartsWith("EXIT"))
                {
                    // Environment.Exit(0); това ти спира цялата програма
                    return;
                }
                else if (currentCommand.StartsWith("PRINT"))
                {
                    int contentStartPosition = currentCommand.IndexOf('(') + 1;
                    string content = currentCommand.Substring(contentStartPosition);

                    for (int j = 0; j < allLoops; j++)
                    {
                        output.Append(content);
                    }
   
                }
                else if (currentCommand.StartsWith("FOR"))
                {
                    int paramsStartPosition = currentCommand.IndexOf('(') + 1;
                    string allParamsInFor = currentCommand.Substring(paramsStartPosition);

                    if (allParamsInFor.Contains(','))
                    {
                        string[] loopParams = allParamsInFor.Split(',');

                        int a = int.Parse(loopParams[0]);
                        int b = int.Parse(loopParams[1]);

                        allLoops = allLoops * (b - a + 1);
                    }
                    else
                    {
                        int value = int.Parse(allParamsInFor);

                        allLoops = allLoops * value;
                    }
                }
            }
        }
    }

    private static void ConvertInputToCommands()
    {
        string allInput = output.ToString();
        output.Clear();

        foreach (char symbol in allInput)
        {
            output.Append(symbol);

            if (symbol == ';')
            {
                allCommands.Add(output.ToString());
                output.Clear();
            }
        }
    }

    private static void ReadInput()
    {
        while (!exit)
        {
            string line = Console.ReadLine();
            output.AppendLine(line);  // Append ne stava tuk

            if (line.Contains("EXIT;"))
            {
                exit = true;
            }
        }
    }
}
