using System;

// Task 07 - Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace Timer
{
    class ConsoleTest
    {
        static void Main()
        {
            // creation of one timer to test with
            Timer myTestTimer = new Timer(3, 15);

            // creation of one delegate to be tested as a parameter of MyTimer
            TimerDelegate firstDelegate = delegate()
            {
                Console.WriteLine("Execute first delegate");
            };

            firstDelegate += delegate()
            { 
                Console.WriteLine(DateTime.Now); 
            };

            // creation of second delegate to be tested as a parameter of MyTimer
            TimerDelegate secondDelegate = delegate()
            {
                Console.WriteLine("Execution of second delegate: {0}", DateTime.Now);
            };

          
            // Run the timer with the first delegate as parameter
            myTestTimer.Run(firstDelegate);

            // change of timer interval and another test with the second delegate as parameter 
            myTestTimer.ExecutionInterval = 2;
            myTestTimer.Run(secondDelegate);

            
        }
    }
}
