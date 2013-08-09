/* Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
 * Do the above in two different ways: with and without using quoted strings. */

using System;

class StringQuotations
{
    static void Main()
    {
        string withQuotedStings = @"The ""use"" of quotations causes difficulties.";
        string withoutQuotedStings = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine("Using quotations: {0}\n", withQuotedStings);
        Console.WriteLine("Without using quotations: {0}\n", withoutQuotedStings);
    }
}

