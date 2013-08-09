/* Write a program to convert from any numeral system of given base s 
 * to any other numeral system of base d (2 ≤ s, d ≤  16).*/

using System;
using System.Collections.Generic;

class ConvertNumeralSystems
{
    static void Main()
    {
        Console.Write("Enter one number: ");
        string input = Console.ReadLine().ToUpper().Replace(" ", null);
        
        Console.Write("Enter the base of your number's numerical system (S >= 2), S = : ");
        int baseS = int.Parse(Console.ReadLine());

        Console.Write("Enter the base of your conversion number's numerical system (D <= 16), D = : ");
        int baseD = int.Parse(Console.ReadLine());

        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        int result = ConvertToDecimal(input, baseS, symbols); // Method to convert to decimal

        List<char> ConversionResult = ConvertFromDecimal(baseD, symbols, result); // Method to convert from decimal the choosen numerical system
        
        Console.Write("Conversion result: ");
        foreach (var item in ConversionResult)
        {
            Console.Write(item);
        }
        Console.WriteLine();
        Console.WriteLine(new string('=', 40));

        Main();
    }

    static List<char> ConvertFromDecimal(int baseD, char[] symbols, int result)
    {
        List<int> resultList = new List<int>();

        while (result > 0)
        {
            resultList.Add(result % baseD);
            result = result / baseD;
        }
        resultList.Reverse();

        List<char> finalResult = new List<char>();

        for (int i = 0; i < resultList.Count; i++)
        {
            for (int j = 0; j < symbols.Length; j++)
            {
                if (resultList[i] == j)
                {
                    finalResult.Add(symbols[j]);
                    break;
                }
            }
        }
        return finalResult;
    }

    static int ConvertToDecimal(string input, int baseS, char[] symbols)
    {
        List<int> inputList = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < symbols.Length; j++)
            {
                if (input[i] == symbols[j])
                {
                    inputList.Add(j);
                    break; 
                }
            }
        }

        int result = 0;

        for (int i = inputList.Count - 1; i >= 0; i--)
        {
            result += int.Parse(inputList[i].ToString()) * (int)Math.Pow(baseS, inputList.Count - 1 - i);
        }
        return result;
    }
}
