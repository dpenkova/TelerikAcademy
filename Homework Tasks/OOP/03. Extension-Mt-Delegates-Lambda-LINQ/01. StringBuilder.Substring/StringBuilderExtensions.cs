using System;
using System.Text;

// Task 01 - Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
// and has the same functionality as Substring in the class String.

public static class StringBuilderExtensions
{
    public static StringBuilder Substring(this StringBuilder input, int index, int length)
    {
        StringBuilder substring = new StringBuilder();

        CheckNegativeIndex(index);
        CheckIndex(input, index);

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException("Cannot accept negative length");
        }
        if (index > input.Length - length)
        {
            throw new ArgumentOutOfRangeException("Index and length must refer to a location within the stringbuilder");
        }
        if (length == 0)
        {
            return substring;
        }

        int endIndex = index + length;

        ProcessSubstring(input, index, substring, endIndex);

        return substring;
    }

    public static StringBuilder Substring(this StringBuilder input, int index)
    {
        StringBuilder substring = new StringBuilder();

        CheckNegativeIndex(index);
        CheckIndex(input, index);

        int endIndex = input.Length;

        ProcessSubstring(input, index, substring, endIndex);

        return substring;
    }

    private static void ProcessSubstring(StringBuilder input, int index, StringBuilder substring, int endIndex)
    {
        for (int i = index; i < endIndex; i++)
        {
            substring.Append(input[i]);
        }
    }

    private static void CheckIndex(StringBuilder input, int index)
    {
        if (index > input.Length)
        {
            throw new ArgumentOutOfRangeException("Index is outside of the input range");
        }
    }

    private static void CheckNegativeIndex(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException("Cannot accept negative index");
        }
    }
}
