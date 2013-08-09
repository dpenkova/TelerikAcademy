/* Declare a character variable and assign it with the symbol that has Unicode code 72. 
 * Hint: first use the Windows Calculator to find the hexadecimal representation of 72. */


using System;

class AssignUnicode72ToChar
{
    static void Main()
    {
        int unicodeChar = 72;
        char char72 = (char)unicodeChar;

        Console.WriteLine("The symbol that has Unicode code 72 is: '{0}'\n", char72);

        // other way to do it 
        char char72SecondWay = '\u0048';
        Console.WriteLine("The symbol that has Unicode code 72 is: '{0}'\n", char72SecondWay);
    }
}

