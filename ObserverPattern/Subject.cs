using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
        public class Subject : ISubject
        {
            private List<IObserver> observers = new List<IObserver>();
            private string Month { get; set; }
            private int SalaryInRs { get; set; }
            private string SalaryStatus { get; set; }

            public Subject(string month, int salaryInrs, string salarystatus)
            {
                   Month = month;
                  SalaryInRs = salaryInrs;
                  SalaryStatus = salarystatus;
            }

            public string getSalaryStatus()
            {
                return SalaryStatus;
            }

            public string setSalaryStatus(string salarystatus)
            {
                   this.SalaryStatus = salarystatus;
                    NotifyObservers();
                   return "Salary status changed";
            }

            public string RegisterObserver(IObserver observer)
            {
                Console.WriteLine("Employee Added : " + ((User)observer).UserName);
                observers.Add(observer);
            return "employee add successfuly";
            }

            public void AddObservers(IObserver observer)
            {
                observers.Add(observer);
            }

            public string RemoveObserver(IObserver observer)
            {
                observers.Remove(observer);
                return "Removed successfully"; 
            }

            public void NotifyObservers()
            {
                Console.WriteLine("\n Month: "+Month+"\n Rs: "+ SalaryInRs + "\n Salary Status:"+SalaryStatus +" \n So notifying all employees ");

                foreach (IObserver observer in observers)
                {
                    observer.update(SalaryStatus);
                }
            }
        }
}
