/* Write a program that shows the binary representation of given 
 * 16-bit signed integer number (the C# type short). */

using System;

class BinarySignedInteger
{
    static void Main()
    {
        Console.Write("Enter one number of type \"short\" : ");

        short input = 0;

        while (!short.TryParse(Console.ReadLine(), out input))
        {
            Console.Write("Invalid entry! Try again: ");
        }

        byte[] arr = new byte[16];

        if (input >= 0)
        {
            arr = ConvertPositive(ref input);   
        }
        else
        {
            input *= -1;
            input -= 1;
            arr = ConvertPositive(ref input);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 1;
                }
                else
                {
                    arr[i] = 0;
                }
            }
        }

        Console.Write("Binary representation : ");
        foreach (var item in arr)
        {
            Console.Write(item);
        }
        Console.WriteLine();

        Main();

        // The easiest way
        //Console.WriteLine("{0}",Convert.ToString(input, 2).PadLeft(16, '0'));
    }

    static byte[] ConvertPositive(ref short input)
    {
        string result = "";

        if (input == 0)
        {
            result = "0";
        }
        else
        {
            while (input > 0)
            {
                result += input % 2;
                input = (short)((int)input / 2);
            }
        }

            byte[] arr = new byte[16];

            int j = arr.Length - 1;

            for (int i = 0; i < result.Length; i++, j--)
            {
                arr[j] = byte.Parse(result[i].ToString());
            }

        return arr;
    }
}
