using System;
using System.Threading;

// Task 08 - Read in MSDN about the keyword event in C# and how to publish events. 
// Re-implement the above using .NET events and following the best practices.

namespace EventTimer
{
    public class Timer
    {
        public event EventHandler Second;
        public EventArgs arg = null;
        public delegate void EventHandler(Timer t, EventArgs arg);

        public void Run(int interval)
        {
            Thread newThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(interval* 1000);
                    if (Second != null)
                    {
                        Second(this, arg);
                    }
                }

            });

            newThread.Start();
        }
    }
}
