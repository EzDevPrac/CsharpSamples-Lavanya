using System;

namespace ObserverPattern
{

        class Program
        {
            static void Main(string[] args)
            {
                
                Subject april = new Subject("April", 10000, "Not Done");

                
                User user1 = new User("Lavanya", april);

                User user2 = new User("Tereena", april);

                User user3 = new User("Raju", april);

                Console.WriteLine("April Month current Salary status : " + april.getSalaryStatus());
                Console.WriteLine();

                april.setSalaryStatus("Done");

                Console.Read();
            }
        }
}

