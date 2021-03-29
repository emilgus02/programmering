using System;
using System.Collections.Generic;
using System.Text;

namespace OBP
{
    interface IChannel
    {
        void Subscribe(Subscriber subscriber);
        void Notify();
    }
}
