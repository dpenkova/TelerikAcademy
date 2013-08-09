/* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
		
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0*/

using System;

    class SolveTasks
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Choose one of the following: \n 1: Reverse Digits of a number\n 2: Calculate the average of a sequence of integers\n 3: Solve a linear equation a * x + b = 0");
            Console.Write("Enter your choise (1, 2 or 3): ");

            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine();
                ReverseDigits();
            }
            else if (choise == 2)
            {
                Console.WriteLine();
                Average();
            }
            else if (choise == 3)
            {
                Console.WriteLine();
                Equation();
            }

            Main();
        }

        static void ReverseDigits()
        {
            Console.Write("Enter the number to be reversed: ");
            string input = Console.ReadLine();
            int numberLength = input.Length;
            int inputNumber = int.Parse(input);

            if (inputNumber < 0)
            {
                Console.WriteLine("You should enter a positive number.");
                return; 
            }

            string output = null;

            for (int i = 0; i < numberLength; i++)
            {
                int last = inputNumber % 10;
                output = output + last.ToString();
                inputNumber = inputNumber / 10;
            }
            Console.WriteLine("Reversed number: {0}", output);
        }

        static void Average()
        {
            Console.Write("Enter one number for the length of your array: ");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber <= 0)
            {
                Console.WriteLine("Your array should have elements.");
                return;
            }

            int[] array = new int[inputNumber];
            Console.WriteLine("Enter your array elements: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} |", array[i]);
            }
            Console.WriteLine();

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            decimal average = (decimal)sum / (decimal)array.Length;

            Console.WriteLine("Average: {0}", average);
        }

        static void Equation()
        {
            Console.Write("Enter number a: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a should not be equal to 0");
                return;
            }

            Console.Write("Enter number b: ");
            int b = int.Parse(Console.ReadLine());

            double result = (double)-b / (double)a;

            Console.WriteLine("Equation solution: {0}", result);
        }
    }
