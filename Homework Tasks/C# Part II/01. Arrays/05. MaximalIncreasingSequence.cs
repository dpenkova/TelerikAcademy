/* Write a program that finds the maximal increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

using System;

    class MaximalIncreasingSequence
    {
        static void Main()
        {
            Console.Write("Enter one positive intrger for the length of your array: ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrLength];

            if (arrLength == 0)
            {
                Console.WriteLine("Your array length is invalid! Try again."); Main();
            }
            else
            {
                Console.WriteLine("Enter your array elements:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0, 2} = ", i);
                    array[i] = int.Parse(Console.ReadLine());
                }

                int sequenceLength = 1;
                int maxSequenceLenght = 1;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] + 1 == array[i])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        if (sequenceLength > maxSequenceLenght)
                        {
                            maxSequenceLenght = sequenceLength;
                        }
                        sequenceLength = 1;
                    }
                }

                if (sequenceLength > maxSequenceLenght)
                {
                    maxSequenceLenght = sequenceLength;
                }

                if (maxSequenceLenght == 1)
                {
                    Console.WriteLine("There are no increasing sequences in your array.");
                    return;
                }

                Console.WriteLine("Max sequence length is: {0}", maxSequenceLenght);

                int startIndex = 0;
                sequenceLength = 1;

                for (int i = 1; i < array.Length; i++)
			    {
                    if (array[i - 1] + 1 == array[i])
                    {
                        sequenceLength++;
                    }
                    else
                    {
                        if (sequenceLength == maxSequenceLenght)
                        {
                            Console.Write("{");
                            for (int j = startIndex; j < startIndex + maxSequenceLenght; j++)
                            {
                                if (j == startIndex + maxSequenceLenght - 1)
                                {
                                    Console.Write("{0}", array[j]);
                                    Console.WriteLine("}");
                                }
                                else
                                {
                                    Console.Write("{0},", array[j]);
                                }
                            }
                        }
                        sequenceLength = 1;
                        startIndex = i;
                    }
			    }
                if (sequenceLength == maxSequenceLenght)
                {
                    Console.Write("{");
                    for (int j = startIndex; j < startIndex + maxSequenceLenght; j++)
                    {
                        if (j == startIndex + maxSequenceLenght - 1)
                        {
                            Console.Write("{0}", array[j]);
                            Console.WriteLine("}");
                        }
                        else
                        {
                            Console.Write("{0},", array[j]);
                        }
                    }
                }
            }

            Main();
        }
    }