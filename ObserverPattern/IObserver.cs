using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{

        public interface IObserver
        {
            string update(string availability);
        }
    
}
