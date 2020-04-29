using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
        public interface ISubject
        {
            string RegisterObserver(IObserver observer);
            string RemoveObserver(IObserver observer);
            void NotifyObservers();
        }
}

