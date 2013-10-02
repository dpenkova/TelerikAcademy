using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<string> durankulakN = new List<string>();

        for (char ch = 'A'; ch <= 'Z'; ch++)
        {
            durankulakN.Add(ch.ToString());
        }

        for (char i = 'a'; i <= 'f'; i++)
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
			{
                durankulakN.Add(i.ToString() + ch.ToString());
			}
            
        }

        //for (int i = 0; i < 168; i++)
        //{
        //    Console.WriteLine("{0,3} : {1}", i, durankulakN[i]);
        //}

        if (input == "A")
        {
            Console.WriteLine(0);
        }   

        else
        {
            // Parse the input to correct durankulakNumbers

            List<string> inputList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    inputList.Add(input[i].ToString() + input[i + 1].ToString());
                    i++;
                }
                else
                {
                    inputList.Add(input[i].ToString());
                }
            }

            //foreach (var item in inputList)
            //{
            //    Console.Write(item + ' ');
            //}


            // transformation to decimal - to decimal calculations

            List<int> inputListNumbers = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = 0; j < durankulakN.Count; j++)
                    if (inputList[i] == durankulakN[j])
                    {
                        inputListNumbers.Add(j);
                        break;
                    }
            }

            ulong result = 0;

            for (int i = inputListNumbers.Count - 1; i >= 0; i--)
            {
                result += ulong.Parse(inputListNumbers[i].ToString()) * (ulong)Math.Pow(168, inputListNumbers.Count - 1 - i);
            }

            Console.WriteLine(result);
        }
    }
}
