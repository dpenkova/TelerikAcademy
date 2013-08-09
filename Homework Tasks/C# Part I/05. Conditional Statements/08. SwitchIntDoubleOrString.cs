/*Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement. */

using System;

class SwithIntDoubleOrString
{
    static void Main()
    {
        Console.Write("Chose a variable type to input:\ndouble\nint\nstring\nEnter your choise: ");
        string variableType = Console.ReadLine();
        
        switch (variableType)
        {
            case "double" :
                double userVarDouble;
                Console.Write("\nEnter your variable: ");
                while (!double.TryParse(Console.ReadLine(), out userVarDouble))
                {
                    Console.Write("\nInvalid enrty! This is not a valid double number!\nTry again: ");
                }
                Console.WriteLine("{0} + 1 = {1}\n", userVarDouble, userVarDouble + 1);
                break;

            case "int":
                int userVarInt;
                Console.Write("\nEnter your variable: ");
                while (!int.TryParse(Console.ReadLine(), out userVarInt))
                {
                    Console.Write("\nInvalid enrty! This is not a valid integer!\nTry again: ");
                }
                Console.WriteLine("{0} + 1 = {1}\n", userVarInt, userVarInt + 1);
                break;

            case "string" :

                Console.Write("\nEnter text: ");
                string userVarStr = Console.ReadLine();
                Console.WriteLine("{0} + * = {1}\n", userVarStr, userVarStr + "*");
                break;

            default:
                Console.WriteLine("\nInvalid entry!");
                break;
        }
    }
}

