/* Extend the program (11) to support also subtraction and multiplication of polynomials.*/

using System; 

class SubstractAndMultiply
{
    static void Main()
    {
        int[] pOne = { 1, 2, 0, 3 };
        int[] pTwo = { 0, 3, 0, 2, 4 };

        PrintPolynomial(pOne);
        PrintPolynomial(pTwo);

        Console.WriteLine("Substracton result:");
        PrintPolynomial(Substract(pOne, pTwo));

        Console.WriteLine("Multiplication result:");
        PrintPolynomial(Multiply(pOne, pTwo));
    }

    static int[] Multiply(int[] one, int[] two)
    {
        int[] result = new int[one.Length + two.Length];
        
        for (int i = 0; i < one.Length; i++)
        {
            for (int j = 0; j < two.Length; j++)
            {
                result[i + j] += one[i] * two[j];  
            } 
        }
        return result;
    }

    static int[] Substract(int[] one, int[] two, bool exchange = false)
    {
        if (one.Length > two.Length)
        {
            return Substract(two, one, exchange = true);
        }

        int[] result = new int[two.Length];

        int i = 0;
        for (; i < one.Length; i++)
        {
            if (exchange)
            {
                result[i] = two[i] - one[i];
            }
            else
            {
                result[i] = one[i] - two[i];
            }
        }
        for (; i < two.Length; i++)
        {
            if (exchange)
            {
                result[i] = two[i];
            }
            else
            {
                result[i] = -two[i];
            }
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
