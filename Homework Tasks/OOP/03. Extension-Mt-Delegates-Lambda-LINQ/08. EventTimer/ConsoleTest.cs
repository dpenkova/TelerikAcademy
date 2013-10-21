using System;

namespace EventTimer
{
    class ConsoleTest
    {
        static void Main()
        {
            Timer timer = new Timer();
            Subscriber subscriber = new Subscriber();
            subscriber.Subscribe(timer);
            timer.Run(3);
        }
    }
}
