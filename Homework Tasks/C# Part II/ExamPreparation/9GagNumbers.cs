using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class GagNumbers
{
    static string[] gagDigits = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" }; 

    static void Main()
    {

        string input = Console.ReadLine();

        List<string> inputDigits = new List<string>();

        //if (gagDigits.Contains(input))
        //{
        //    inputDigits.Add(input);

        //    //for (int i = 0; i < gagDigits.Length; i++)
        //    //{
        //    //    if (input == gagDigits[i])
        //    //    {
        //    //        Console.WriteLine(i);
        //    //        break;
        //    //    }
        //    //}
        //}
        //else
        //{
            // parse to Gag Digits
            for (int i = 1; i < input.Length; i++)
            {
                string current = input[i - 1].ToString() + input[i].ToString();

                while (!gagDigits.Contains(current))
                {
                    i++;
                    current += input[i].ToString();
                }

                inputDigits.Add(current);
                i++;
            }

            //foreach (var item in inputDigits)
            //{
            //    Console.WriteLine(item);
            //}
     //   }

        BigInteger result = ConvertToDecimal(inputDigits);
        Console.WriteLine(result);
    }

    static BigInteger ConvertToDecimal(List<string> inputDigits)
    {
        // convert to decimal digits
        List<int> inputList = new List<int>();

        for (int i = 0; i < inputDigits.Count; i++)
        {
            for (int j = 0; j < gagDigits.Length; j++)
            {
                if (inputDigits[i] == gagDigits[j])
                {
                    inputList.Add(j);
                    break;
                }
            }
        }

        // calculate decimal number
        BigInteger result = 0;

        for (int i = inputList.Count - 1; i >= 0; i--)
        {
            //result += inputList[i] * (BigInteger)Math.Pow(9, inputList.Count - 1 - i); // Явно при по-голям резултат MathPow не връща коректни стойности, затова метод за вдигане на степен, който връща BigInteger
            result += inputList[i] * PowerOfNine(inputList.Count - i - 1);
        }
        return result;
    }

    static BigInteger PowerOfNine(int power)
    {
        BigInteger result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }

        return result;
    }
}