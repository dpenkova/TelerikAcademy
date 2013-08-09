/* Write a method that asks the user for his name and prints “Hello, <name>” 
 * (for example, “Hello, Peter!”). Write a program to test this method.*/

using System;

public class Hello
{
    public static void Main()
    {
        Console.Write("Enter a name: ");
        string inputName = Console.ReadLine();
        PrintHelloName(inputName);
    }

    public static void PrintHelloName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}