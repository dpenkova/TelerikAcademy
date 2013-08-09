/* Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
 * Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly. */

using System;
using System.Text;

class PrintAnIsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        // Using HEX
        char charHex = '\u00A9';
        
        Console.WriteLine("   {0}", charHex);
        Console.WriteLine("  {0} {1}", charHex, charHex);
        Console.WriteLine(" {0}   {1}", charHex, charHex);
        Console.WriteLine("{0} {1} {2} {3}", charHex, charHex, charHex, charHex);

        // Using symbol from Character Map
        Console.WriteLine(@"   
   ©
  © ©
 ©   ©
© © © ©");
    }
}

