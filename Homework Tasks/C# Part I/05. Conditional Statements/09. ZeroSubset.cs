/*We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
 * Example: 3, -2, 1, 1, 8 --> 1+1-2=0.*/

using System;

    class ZeroSubset
    {
        static void Main()
        {
            int a, b, c, d, e;
            Console.Write("Enter your first number: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Invalid entry! Try again: ");
            }
            Console.Write("Enter your second number: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Invalid entry! Try again: ");
            }
            Console.Write("Enter your third number: ");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Invalid entry! Try again: ");
            }
            Console.Write("Enter your fourth number: ");
            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.Write("Invalid entry! Try again: ");
            }
            Console.Write("Enter your fifth number: ");
            while (!int.TryParse(Console.ReadLine(), out e))
            {
                Console.Write("Invalid entry! Try again: ");
            }

            if (a + b + c == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", a, b, c);
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", a, c, d);
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", a, b, d);
            }
            if (a + b + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", a, b, e);
            }
            if (a + c + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", a, c, e);
            }
            if (a + d + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", a, d, e);
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", b, c, d);
            }
            if (b + c + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", b, c, e);
            }
            if (b + d + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", b, d, e);
            }
            if (c + d + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2} = 0", c, d, e);
            }
            if (a + b == 0)
            {
                Console.WriteLine("{0}, {1} = 0", a, b);
            }
            if (a + c == 0)
            {
                Console.WriteLine("{0}, {1} = 0", a, c);
            }
            if (a + d == 0)
            {
                Console.WriteLine("{0}, {1} = 0", a, d);
            }
            if (a + e == 0)
            {
                Console.WriteLine("{0}, {1} = 0", a, e);
            }
            if (b + c == 0)
            {
                Console.WriteLine("{0} {1} = 0", b, c);
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0}, {1} = 0", b, d);
            }
            if (b + e == 0)
            {
                Console.WriteLine("{0}, {1} = 0", b, e);
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0}, {1} = 0", c, d);
            }
            if (c + e == 0)
            {
                Console.WriteLine("{0}, {1} = 0", c, e);
            }
            if (e + d == 0)
            {
                Console.WriteLine("{0}, {1} = 0", e, d);
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3} = 0", a, b, c, d);
            }
            if (a + c + d + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3} = 0", a, c, d, e);
            }
            if (b + c + d + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3} = 0", b, c, d, e);
            }
            if (d + e + a + b == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3} = 0", d, e, a, b);
            }
            if (e + a + b + c == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3} = 0", e, a, b, c);
            }
            if (a + b + c + d + e == 0)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4} = 0", a, b, c, d, e);
            }
        }
    }
