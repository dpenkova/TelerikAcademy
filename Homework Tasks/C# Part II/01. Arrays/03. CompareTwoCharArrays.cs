/* Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;

    class CompareTwoCharArrays
    {
        static void Main()
        {
            Console.Write("Enter your first char array as string: ");
            char[] arrayOne = Console.ReadLine().ToCharArray();

            Console.Write("Enter your second char array as string: ");
            char[] arrayTwo = Console.ReadLine().ToCharArray();
            
            int compareLength = 0;
            bool areEqualLength = false;

            if (arrayOne.Length == arrayTwo.Length)
            {
                compareLength = arrayOne.Length;
                areEqualLength = true;
            }
            else if (arrayOne.Length > arrayTwo.Length)
            {
                compareLength = arrayTwo.Length;
            }
            else
            {
                compareLength = arrayOne.Length;
            }

            for (int i = 0; i < compareLength; i++)
            {
                // this is to escape the "if" statement for each element, the code works with or without it
                //while (i < compareLength - 1 && arrayOne[i] == arrayTwo[i])
                //{
                //    i++;
                //}

                if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine("Your second array is earlier.");
                    return;
                }
                else if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine("Your first array is earlier.");
                    return; 
                }
            }

            if (areEqualLength)
            {
                Console.WriteLine("The two arrays are equal");
            }
            else if (arrayOne.Length > arrayTwo.Length)
            {
                Console.WriteLine("Your second array is earlier.");
            }
            else
	        {
                Console.WriteLine("Your first array is earlier.");
	        }
        }
    }