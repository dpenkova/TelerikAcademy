/* Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
 * 34.567839023, 12.345, 8923.1234857, 3456.091? */

using System;

class FloatAndDoubleVariables
{
    static void Main()
    {
        double double_01 = 34.567839023;
        float float_01 = 12.345f;
        double double_02 = 8923.1234857;
        float float_02 = 3456.091f;

        Console.WriteLine("Double 01: {0}", double_01);
        Console.WriteLine("Float 01: {0}", float_01);
        Console.WriteLine("Double 02: {0}", double_02);
        Console.WriteLine("Float 02: {0}\n", float_02);
    }
}

