/* Declare two string variables and assign them with “Hello” and “World”. 
 * Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
 * Declare a third string variable and initialize it with the value of the object variable (you should perform type casting). */

using System;

class StringAndObjectCasting
{
    static void Main()
    {
        string stringHello = "Hello";
        string stringWorld = "World";
        object concatenate = stringHello + " " + stringWorld;

        string convertObject = (string)concatenate;
        // string convertObject = concatenate.ToString();  --> another way
        Console.WriteLine("{0}\n", concatenate);
    }
}

