/*
* 11. * Write a program that converts a number in the range [0...999]
* to a text corresponding to its English pronunciation. 
* 
* Examples:
* 0 -> "Zero"
* 273 -> "Two hundred seventy three"
* 400 -> "Four hundred"
* 501 -> "Five hundred AND one"
* 711 -> "Seven hundred AND eleven"
*/

using System;
using System.Globalization;
using System.Threading;

class ConvertNumberToText
{
    static void Main()
    {
        //Get the culture property of the thread.
        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
        //Create TextInfo object.
        TextInfo textInfo = cultureInfo.TextInfo;

        string[] oneToNine = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tenToNineteen = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] twentyToNinety = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        Console.Write("Enter one integer in the range [0 - 999]: ");
        int number;
        int numLenght = 0;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid entry! Try again: ");
        }

        numLenght = number.ToString().Length;

        if (number > 999 || number < 0)
        {
            Console.WriteLine("Your number is out of the range [0 - 999].");
        }
        else
        {
            if (numLenght == 1)
            {
                Console.WriteLine("{0}", textInfo.ToTitleCase(oneToNine[number]));
            }
            else if (numLenght == 2)
            {
                if (number >= 10 && number <= 19)
                {
                    int tempNumber = number - 10;
                    Console.WriteLine("{0}", textInfo.ToTitleCase(tenToNineteen[tempNumber]));
                }
                else if (number >= 20 && number % 10 == 0)
                {
                    int tempNumber = number / 10;
                    Console.WriteLine("{0}", textInfo.ToTitleCase(twentyToNinety[tempNumber]));
                }
                else if (number >= 20 && number % 10 != 0)
                {
                    int secondDigit = number % 10;
                    number = number / 10;
                    int firstDigit = number % 100;

                    Console.Write("{0} ", textInfo.ToTitleCase(twentyToNinety[firstDigit]));
                    Console.WriteLine("{0}", oneToNine[secondDigit]);
                }
            }
            else if (numLenght == 3)
            {
                int thirdNumber = number % 10;
                int tempNumber = (number % 100);

                number = number / 10;
                int secondNumber = number % 10;
                int firstNumber = number / 10;

                if (thirdNumber == 0 && secondNumber == 0)
                {
                    Console.WriteLine("{0} hundred", textInfo.ToTitleCase(oneToNine[firstNumber]));
                }
                else if (secondNumber == 0)
                {
                    Console.WriteLine("{0} hundred and {1}", textInfo.ToTitleCase(oneToNine[firstNumber]), oneToNine[thirdNumber]);
                }
                else if (secondNumber == 1)
                {
                    tempNumber = tempNumber - 10;
                    Console.WriteLine("{0} hundred and {1}", textInfo.ToTitleCase(oneToNine[firstNumber]), tenToNineteen[tempNumber]);
                }
                else if (thirdNumber == 0)
                {
                    tempNumber = tempNumber / 10;
                    Console.WriteLine("{0} hundred {1}", textInfo.ToTitleCase(oneToNine[firstNumber]), twentyToNinety[tempNumber]);
                }
                else if (thirdNumber != 0 && secondNumber != 0) 
                {
                    Console.WriteLine("{0} hundred {1} {2}", textInfo.ToTitleCase(oneToNine[firstNumber]), twentyToNinety[secondNumber], oneToNine[thirdNumber]);
                }
            }
        }
    }
}

