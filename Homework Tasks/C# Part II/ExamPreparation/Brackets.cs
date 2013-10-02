using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Brackets
{
    static void Main()
    {
        int inputLines = int.Parse(Console.ReadLine());
        string indent = Console.ReadLine();
        char indentChar = indent[0];

        StringBuilder input = new StringBuilder();

        for (int i = 0; i < inputLines; i++)
        {
            input.Append((Regex.Replace(Console.ReadLine(), @"\s+", " ", RegexOptions.Compiled)).Replace("{ ", "{").Replace(" }", "}").Replace("} ", "}"));
            input.Append("\n");
        }

        string clearedText = input.ToString();
        clearedText = clearedText.Replace("\n{", "{").Replace("\n}", "}").Replace("{\n", "{").Replace("}\n", "}").Replace("\n\n", "\n").Replace("\n ", "\n").Replace("{ ", "{").Replace("} ", "}").Replace("\n{", "{").Replace("\n}", "}").Replace("{\n", "{").Replace("}\n", "}").Replace("\n\n", "\n").Replace("\n ", "\n");
        clearedText = Regex.Replace(clearedText, @"\t", " ", RegexOptions.Compiled);
        clearedText = clearedText.Replace("\n{", "{").Replace("\n}", "}").Replace("{\n", "{").Replace("}\n", "}").Replace("\n\n", "\n").Replace("\n ", "\n").Replace("{ ", "{").Replace("} ", "}").Replace("\n{", "{").Replace("\n}", "}").Replace("{\n", "{").Replace("}\n", "}").Replace("\n\n", "\n").Replace("\n ", "\n");


        //string [] text = input.ToString().Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);
        //input.Clear();

        //for (int i = 0; i < text.Length; i++)
        //{
        //    input.Append(text[i]);
        //    input.Append(" ");
        //}

        //string clearedText = input.ToString().Replace(" {", "{").Replace("{ ", "{").Replace(" }", "}").Replace("} ", "}");

        int countPrintedOpenBrackets = 0;
        int indentCount = indent.Length;
        int index = 0;

        // print first line
        for ( ; index < clearedText.Length - 1; index++)
        {
            
            if (clearedText[index] != '{')
            {
                Console.Write(clearedText[index]);                
            }
            else if (clearedText[index] == '{')
            {
                break;
            }
        }

        StringBuilder line = new StringBuilder();

        for (; index < clearedText.Length; index++)
        {
            
            if (clearedText[index] == '{')
            {
                if (index == 0)
                {
                    Console.Write("{0}{1}", new string(indentChar, countPrintedOpenBrackets * indentCount), clearedText[index]);
                }
                else
                {
                    Console.Write("\n{0}{1}", new string(indentChar, countPrintedOpenBrackets * indentCount), clearedText[index]);
                }
                countPrintedOpenBrackets++;
                line.Clear();
                line.Append(new string(indentChar, countPrintedOpenBrackets * indentCount));
            
            }
            else if (clearedText[index] == '}')
            {
                countPrintedOpenBrackets--;
                Console.Write("\n{0}{1}", new string(indentChar, countPrintedOpenBrackets * indentCount), clearedText[index]);
                line.Clear();
                line.Append(new string(indentChar, countPrintedOpenBrackets * indentCount));
            }
            else if (clearedText[index] != '{')
            {
                while (clearedText[index] != '{' && clearedText[index] != '}' && index < clearedText.Length)
                {
                    if (clearedText[index] == '\n')
                    {
                        line.Append(clearedText[index]);
                        line.Append(new string(indentChar, countPrintedOpenBrackets * indentCount));
                    }
                    else
                    {
                        line.Append(clearedText[index]);
                    }
                    if (index < clearedText.Length - 1)
                    {
                        index++;
                    }
                    else break;
                    
                }

                if (char.IsWhiteSpace(line[0]))
                {
                    line.Remove(0, 1);
                }

                Console.Write("\n" + line.ToString().TrimEnd().TrimStart());
                line.Clear();

                if (clearedText[index] == '{' || clearedText[index] == '}')
                {
                    index--;
                }
            }
        }
    }
}
