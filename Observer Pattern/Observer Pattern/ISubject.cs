using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    interface ISubject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify();
    }
}
