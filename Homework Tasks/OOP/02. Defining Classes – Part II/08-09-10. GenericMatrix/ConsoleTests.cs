using System;

namespace GenericMatrix
{
    class ConsoleTests
    {
        static void Main()
        {
            //DateTime start = DateTime.Now;

            // create an object of type GenericMatrix

            Matrix<double> testOne = new Matrix<double>(2, 3);
            Matrix<double> testTwo = new Matrix<double>(2, 3);

            // test indexer
            testOne[0, 0] = 1.1;
            testOne[0, 1] = 2.2;
            testOne[0, 2] = 1.1;
            testOne[1, 0] = 5.5;
            testOne[1, 1] = 2.2;
            testOne[1, 2] = 3.3;

            testTwo[0, 0] = -1.1;
            testTwo[0, 1] = -2.2;
            testTwo[0, 2] = 1.1;
            testTwo[1, 0] = -5.5;
            testTwo[1, 1] = -2.2;
            testTwo[1, 2] = -3.3;

            // test ToString() override
            Console.WriteLine(testOne);
            Console.WriteLine(testTwo);

            // test addition of matrixes
            Console.WriteLine(testTwo + testOne);
            Console.WriteLine(testOne + testTwo);

            // test substracion of matrixes
            Console.WriteLine(testTwo - testOne);
            Console.WriteLine(testOne - testTwo);

            // test multiplication 

            Matrix<int> m1 = new Matrix<int>(3, 2);
            Matrix<int> m2 = new Matrix<int>(2, 2);

            m1[0, 0] = 1;
            m1[0, 1] = 3;
            m1[1, 0] = 0;
            m1[1, 1] = -2;
            m1[2, 0] = 4;
            m1[2, 1] = 1;

            m2[0, 0] = 7;
            m2[0, 1] = 9;
            m2[1, 0] = 5;
            m2[1, 1] = 2;

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m1 * m2);

            // Console.WriteLine(DateTime.Now - start);

            // test bool true/ false
            Matrix<int> m3 = new Matrix<int>(3, 3);
            Console.WriteLine(m3);

            if (m3)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
