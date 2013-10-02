// Exam 06 Feb 2012 - 60 points

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class PHPVariables
{
    static string currentLine;
    static List<string> vars = new List<string>();
    static string regexPattern = @"[$]\w+";
    //static bool isCommentLine = false;

    static void Main()
    { 
        while (currentLine != "?>")
        {
            currentLine = Console.ReadLine();
            ProcessLine(currentLine);
        }

        Console.WriteLine(vars.Count);

        for (int v = 0; v < vars.Count;  v++)
        {
            StringBuilder cleared = new StringBuilder();

            for (int i = 1; i < vars[v].Length; i++)
            {
                cleared.Append(vars[v][i]);
            }

            vars[v] = cleared.ToString();
        }

        vars.Sort();

        foreach (var item in vars)
        {
            Console.WriteLine(item);
        }
    }

    private static void ProcessLine(string currentLine)
    {
        //if (currentLine[0] + currentLine[1].ToString() == "/*" && currentLine[currentLine.Length - 2] + currentLine[currentLine.Length - 1].ToString() == "*/")
        //{
        //}
        //else
        //{
        //    if (currentLine.Contains(" /*") || currentLine[0].ToString() + currentLine[1] == "/*")
        //    {
        //        isCommentLine = true;
        //    }
        //    else if (currentLine.Contains(" */") && !currentLine.Contains("*/\""))
        //    {
        //        isCommentLine = false;
        //        return;
        //    }
        //}

        MatchCollection currentLineVars = Regex.Matches(currentLine, regexPattern, RegexOptions.IgnoreCase);

        if (currentLineVars.Count != 0)
        {
            for (int i = 0; i < currentLineVars.Count; i++)
            {
                string currentVar = currentLineVars[i].ToString();
                int currentVarIndex = currentLine.IndexOf(currentVar);

                if ( currentVarIndex == 0)
                {
                    if (!vars.Contains(currentVar))
                    {
                        vars.Add(currentVar);
                    }
                }
                else 
                {
                    if (currentLine[currentVarIndex - 1] == '\\')
                    {
                        //do nothing
                    }
                    else if (currentLine[0] + currentLine[1].ToString() == "/*" && currentLine[currentLine.Length - 2] + currentLine[currentLine.Length - 1].ToString() == "*/")
                    {
                        //do nothing
                    }
                    else if (currentLine[0] + currentLine[1].ToString() == "//" )
                    {
                        //do nothing
                    }
                    else if (currentLine[0] == '#')
                    {
                        //do nothing
                    }
                    else if (currentLine.Contains(" //") && currentVarIndex > currentLine.IndexOf(" //"))
                    {
                        //do nothing
                    }
                    else
                    {
                        if (!vars.Contains(currentVar))
                        {
                            vars.Add(currentVar);
                        }
                    }
                }
            }
        }
    }
}       