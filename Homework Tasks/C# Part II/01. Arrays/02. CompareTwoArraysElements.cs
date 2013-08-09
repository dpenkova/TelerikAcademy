/* Write a program that reads two arrays from the console and compares them 
 * element by element.*/

using System;

    class CompareTwoArraysElements
    {
        static void Main()
        {
            Console.Write("Enter an integer for the length of the two arrays to compare: ");
            int arrawLength = int.Parse(Console.ReadLine());

            int[] matrixOne = new int[arrawLength];
            int[] matrixTwo = new int[arrawLength];

            Console.WriteLine("Enter the {0} elements of your first array.", arrawLength);

            for (int i = 0; i < matrixOne.Length; i++)
            {
                matrixOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the {0} elements of your second array.", arrawLength);

            for (int i = 0; i < matrixTwo.Length; i++)
            {
                matrixTwo[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < arrawLength; i++)
            {
                if (matrixOne[i] == matrixTwo[i])
                {
                    Console.WriteLine("{0} == {1} ? --> True", matrixOne[i], matrixTwo[i]);
                }
                else
                {
                    Console.WriteLine("{0} == {1} ? --> False", matrixOne[i], matrixTwo[i]);
                }
            }


            // Another way - create third array to store compare results 

            // string[] compareResult = new string[arrawLength];
            //for (int i = 0; i < arrawLength; i++)
            //{
            //    if (matrixOne[i] == matrixTwo[i])
            //    {
            //        compareResult[i] = "True";
            //    }
            //    else
            //    {
            //        compareResult[i] = "False";
            //    }
            //}

            //// print items in matrix one
            //foreach (var item in matrixOne)
            //{
            //     Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //// print items in matrix two
            //foreach (var item in matrixTwo)
            //{
            //     Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //// print compare result
            //foreach (var item in compareResult)
            //{
            //     Console.Write(item + " ");
            //}
            //Console.WriteLine();
        }
    }