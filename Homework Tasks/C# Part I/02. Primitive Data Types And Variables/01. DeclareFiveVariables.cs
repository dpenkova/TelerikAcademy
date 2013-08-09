/* Declare five variables choosing for each of them the most appropriate of the types 
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. */

using System;

class DeclareFiveVariables
{
    static void Main()
    {
        ushort @ushort = 52130;
        sbyte @sbyte = -115;
        int @int = 4825932;
        byte @byte = 97;
        short @short = -10000;

        Console.WriteLine("ushort: {0}", @ushort);
        Console.WriteLine("sbyte: {0}", @sbyte);
        Console.WriteLine("int: {0}", @int);
        Console.WriteLine("byte: {0}", @byte);
        Console.WriteLine("short: {0}", @short);

    }
}

