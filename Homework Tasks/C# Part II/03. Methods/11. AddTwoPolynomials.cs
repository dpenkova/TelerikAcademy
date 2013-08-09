/* Write a method that adds two polynomials. Represent them as arrays of their 
 * coefficients as in the example below: x2 + 5 = 1x2 + 0x + 5 -> |5|0|1|*/

using System;

class AddTwoPolynomials
{
    static void Main()
    {
        int[] pOne = { 0, 3, 0, 2, 4 };
        int[] pTwo = { 1, 2, 0, 3 };

        PrintPolynomial(pOne);
        PrintPolynomial(pTwo);
        PrintPolynomial(Add(pOne, pTwo));
    }

    static int[] Add(int[] one, int[] two)
    {
        if (one.Length > two.Length)
        {
            return Add(two, one);
        }
        int[] result = new int [two.Length];

        int i = 0;
        for (;  i < one.Length; i++)
        {
            result[i] = one[i] + two[i];
        }
        for (; i < two.Length; i++)
        {
            result[i] = two[i];
        }

        return result;
    }

    static void PrintPolynomial(int[] poly)
    {
        for (int i = poly.Length - 1; i >= 0; i--)
        {
            Console.Write(poly[i] != 0 ? (poly[i] + "*x^" + i + " + ") : "");
        }
        Console.Write("\b\b" + " ");
        Console.WriteLine();
    }
}
