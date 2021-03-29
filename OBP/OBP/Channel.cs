using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    class Channel : IChannel
    {
        private List<Subscriber> subscribers = new List<Subscriber>();
        public int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                else
                {
                    Console.WriteLine("There is no new video");
                }
                _int = value;
            }
        }

            public void Subscribe(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Notify()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
