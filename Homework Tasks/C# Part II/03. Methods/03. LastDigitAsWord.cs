/* Write a method that returns the last digit of given integer as an English word. 
* Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine". */

using System;

class LastDigitAsWord
{
    static void Main()
    {
        Console.Write("Enter one integer to read its last digit: ");
        int inputNumber = int.Parse(Console.ReadLine());

        ReadLastDigit(inputNumber);

        Main();
    }
        static void ReadLastDigit(int input)
        {
            string[] matrix = 
            {
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            };

            int lastDigit = input % 10;

            for (int i = 0; i < matrix.Length; i++)
		    {
			    if (lastDigit == i)
	            {
		            Console.WriteLine("{0} -> {1}", input, matrix[i]);
	            }
		    }
        }
}