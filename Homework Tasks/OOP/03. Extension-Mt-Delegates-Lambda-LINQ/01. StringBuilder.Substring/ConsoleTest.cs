using System;
using System.Text;

class ConsoleTest
{
    static void Main()
    {
        StringBuilder input = new StringBuilder("This is a test for the Extension method Substring");

        Console.WriteLine(input.Substring(23));
        Console.WriteLine(input.Substring(23, 16));
        Console.WriteLine(input.Substring(23, 0));

        Console.WriteLine(StringBuilderExtensions.Substring(new StringBuilder("test something"), 5, 4));

        //Console.WriteLine(input.Substring(51, 4));
        //Console.WriteLine(input.Substring(-1, 0));
        //Console.WriteLine(input.Substring(23, -2));
        //Console.WriteLine(input.Substring(39, 24));

    }
}