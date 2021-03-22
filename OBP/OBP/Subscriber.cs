using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    class Subscriber : ISubscriber
    {
        public string SubscriberName { get; private set; }

        public Subscriber(string name)
        {
            SubscriberName = name;
        }

        public void Update()
        {
            Console.WriteLine(SubscriberName + ": A new video is up");
        }
    }
}
