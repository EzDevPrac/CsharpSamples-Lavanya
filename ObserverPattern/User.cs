using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{ 
        public class User : IObserver
        {
            public string UserName { get; set; }

            public User(string userName, ISubject subject)
            {
                UserName = userName;
                subject.RegisterObserver(this);
            }

            public string update(string status)
            {
                Console.WriteLine("Hello " + UserName + ",your salary is " + status + " enjoy.");
                return "Updated sucess";
            }
        }
    
}
