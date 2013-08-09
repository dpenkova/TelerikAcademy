/* Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.*/

using System;

    public class SumUsingArrays
    {
        public static void Main()
        {
            Console.Write("Enter your first number: ");
            string firstInput = Console.ReadLine();
            
            Console.Write("Enter your second number: ");
            string secondInput = Console.ReadLine();

            AddNumbers(firstInput, secondInput);

            Main();
        }

        public static void AddNumbers(string firstInput, string secondInput)
        {
            int arrayLength = int.MinValue; 

            if (firstInput.Length >= secondInput.Length)
            {
                arrayLength = firstInput.Length;
            }
            else
            {
                arrayLength = secondInput.Length;
            }

            int[] arrayOne = CreateArray(firstInput, arrayLength);
            int[] arrayTwo = CreateArray(secondInput, arrayLength);

            int[] result = ResultArray(arrayOne, arrayTwo);
            PrintResult(result);
        }

        public static void PrintResult(int[] array)
        {
            string resultOutput = null; 

            if (array[array.Length - 1] != 0)
            {
                resultOutput = array[array.Length - 1].ToString();
            }

            for (int i = array.Length - 2; i >= 0; i--)
            {
                resultOutput += array[i].ToString();
            }
            Console.WriteLine("Your result is: {0}", resultOutput);
        }

        public static int[] ResultArray(int[] x, int[] y)
        {
            int[] resultArray = new int[x.Length + 1];

            resultArray[0] = (x[0] + y[0]) % 10;
            int addition = 0;

            for (int i = 1; i < x.Length; i++)
            {
                if (((x[i] + y[i]) % 10) + ((x[i - 1] + y[i - 1]) / 10) + addition == 10)
                {
                    resultArray[i] = 0;
                    addition = 1;
                }
                else
                {
                    resultArray[i] = ((x[i] + y[i]) % 10) + ((x[i - 1] + y[i - 1]) / 10) + addition;
                    addition = 0;
                }
            }

            resultArray[resultArray.Length - 1] = (x[x.Length - 1] + y[y.Length - 1]) / 10 + addition;

            return resultArray;
        }

        public static int[] CreateArray(string input, int length)
        {
            int[] array = new int[length];

            for (int i = input.Length - 1; i >= 0; i--)
            {
                array[input.Length - 1 - i] = int.Parse(input[i].ToString());
            }
            return array;
        }
    }
