using System;
using System.Threading;

// Task 07 - Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace Timer
{
    public delegate void TimerDelegate();

    class Timer
    {
        // Properties
        public uint ExecutionInterval { get; set; }  // in seconds
        public uint TotalExecutionTime { get; set; } // in seconds

        // Constructor
        public Timer(uint interval, uint total)
        {
            this.ExecutionInterval = interval;
            this.TotalExecutionTime = total;
        }

        // Method to start the timer action, accepting a delegate as parameter
        public void Run(TimerDelegate execute)
        {
            DateTime timerEnd = DateTime.Now.AddSeconds(TotalExecutionTime);
            
            while (DateTime.Now < timerEnd)
            {
                Thread.Sleep((int)this.ExecutionInterval * 1000);
                execute(); 
            }
        }
    }
}
