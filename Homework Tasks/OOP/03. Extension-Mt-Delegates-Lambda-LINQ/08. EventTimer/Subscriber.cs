using System;

namespace EventTimer
{
    class Subscriber
    {
        public void Subscribe(Timer pub)
        {
            pub.Second += new Timer.EventHandler(DoSomething);
        }
        private void DoSomething(Timer t, EventArgs arg)
        {
            Console.WriteLine("Execute at: {0}", DateTime.Now);
        }
    }
}
