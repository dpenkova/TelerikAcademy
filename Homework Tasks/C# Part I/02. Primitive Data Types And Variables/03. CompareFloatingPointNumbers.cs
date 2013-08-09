/* Write a program that safely compares floating-point numbers with precision of 0.000001. 
 * Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true */

using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        bool result_01 = false;
        bool result_02 = false;
        double number_01 = 0.0;
        double number_02 = 0.0;
        
        while (result_01 == false || result_02 == false)
        {

            Console.Write("Enter number 1: ");
            result_01 = double.TryParse(Console.ReadLine(), out number_01);

            Console.Write("Enter number 2: ");
            result_02 = double.TryParse(Console.ReadLine(), out number_02);
                        
            if (result_01 == false || result_02 == false)
            {
                Console.WriteLine("\n\nYou must enter a valid decimal number!\n");
            } 

        }

        double substractNumbers = Math.Abs(number_01 - number_02);
        
        if (substractNumbers < 0.000001)
        {
            Console.WriteLine("\nComparison result between the numbers {0} and {1} is: True\n", number_01, number_02);
        }

        else
        {
            Console.WriteLine("\nComparison result between the numbers {0} and {1} is: False\n", number_01, number_02);
        }
    }
}

