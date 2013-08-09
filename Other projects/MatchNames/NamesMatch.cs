using System;
using System.Collections.Generic;

class NamesPersonMatch
{
    static void Main()
    {
        Console.Write("Enter first person names: ");
        string firstPersonInput = Console.ReadLine();
        Console.Write("Enter second person names: ");
        string secondPersonInput = Console.ReadLine();
        Console.WriteLine(new string('-', 80));

        string firstPerson = firstPersonInput.Replace(" ", null);
        firstPerson = firstPerson.Replace("-", null);
        string secondPerson = secondPersonInput.Replace(" ", null);
        secondPerson = secondPerson.Replace("-", null);

        string wholeStringFirstToSecond = firstPerson.ToLower() + secondPerson.ToLower();
        string wholeStringSecondToFirst = secondPerson.ToLower() + firstPerson.ToLower();

        List<char> inputListFirstToSecond = new List<char>();

        foreach (var item in wholeStringFirstToSecond)
        {
            inputListFirstToSecond.Add(item);
        }

        List<char> inputListSecondToFirst = new List<char>();

        foreach (var item in wholeStringSecondToFirst)
        {
            inputListSecondToFirst.Add(item);
        }

        List<int> countLettersFirstToSecond = CountLetters(inputListFirstToSecond);
        List<int> countLettersSecondToFirst = CountLetters(inputListSecondToFirst);

        Calculate(countLettersFirstToSecond, firstPersonInput, secondPersonInput);
        Calculate(countLettersSecondToFirst, secondPersonInput, firstPersonInput);

        Main();
    }

    private static List<int> CountLetters(List<char> inputList)
    {
        List<int> countLetters = new List<int>();

        for (int i = 0; i < inputList.Count; i++)
        {
            int counter = 1;

            for (int j = i + 1; j < inputList.Count; j++)
            {
                if (inputList[i] == inputList[j])
                {
                    counter++;
                    inputList.RemoveAt(j);
                    j--;
                }
            }
            countLetters.Add(counter);
        }
        return countLetters;
    }

    static void Calculate(List<int> mList, string firstPerson, string secondPerson)
    {
        RebuildList(mList);

        if (mList.Count == 2 || (mList.Count == 3 && mList[0] == 1 && mList[1] == 0 && mList[2] == 0))
        {
            Console.Write("{0} --> {1} : ", firstPerson, secondPerson);
            Print(mList);
            Console.Write("%");
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));
        }
        else
        {
            int middleIndex = (mList.Count / 2) - 1;
            List<int> newList = new List<int>();
            for (int i = 0; i <= middleIndex; i++)
            {
                newList.Add(mList[i] + mList[mList.Count - 1 - i]);
            }
            if (mList.Count % 2 != 0)
            {
                newList.Add(mList[middleIndex + 1]);
            }
            Calculate(newList, firstPerson, secondPerson);
        }
    }

    static void Print(List<int> mList)
    {
        foreach (var item in mList)
        {
            Console.Write("{0}", item);
        }
    }

    static void RebuildList(List<int> countLetters)
    {
        for (int i = 0; i < countLetters.Count; i++)
        {
            if (countLetters[i] > 9)
            {
                countLetters.Add(i);

                for (int j = countLetters.Count - 1; j >= i; j--)
                {
                    if (j > i + 1)
                    {
                        countLetters[j] = countLetters[j - 1];
                    }
                    else if (j == i + 1)
                    {
                        countLetters[j] = countLetters[i] % 10;
                    }
                    else if (j == i)
                    {
                        countLetters[j] = countLetters[i] / 10;
                    }
                }
            }
        }
    }
}

