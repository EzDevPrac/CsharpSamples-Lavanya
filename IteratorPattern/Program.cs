using System;

namespace IteratorPattern
{
        public class Program
        {
            static void Main()
            {
                // Build a collection
                ConcreteCollection collection = new ConcreteCollection();

                collection.AddEmployee(new Elempoyee("Lavanya", 100));
                collection.AddEmployee(new Elempoyee("Tereena", 101));
                collection.AddEmployee(new Elempoyee("Raju", 102));
                collection.AddEmployee(new Elempoyee("Karan", 103));
                collection.AddEmployee(new Elempoyee("Shashank", 104));

                // Create iterator
                Iterator iterator = collection.CreateIterator();

                //looping iterator      
                Console.WriteLine("Iterating over collection:");

                for (Elempoyee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
                {
                    Console.WriteLine("ID:"+emp.ID + " Name:"+emp.Name);
                }
                Console.Read();
            }
        }
}
