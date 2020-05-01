using System;
using Xunit;

namespace IteratorPattern.Testing
{
    public class IteratorTest
    {
        ConcreteCollection collection = new ConcreteCollection();
        [Fact]
        public void First_ShouldReturn_FirstEmployee()
        {
            Elempoyee emp = new Elempoyee("Lavanya", 100);
            collection.AddEmployee(emp);
            collection.AddEmployee(new Elempoyee("Tereena", 101));

            Iterator iterator = collection.CreateIterator();
            Elempoyee expected = iterator.First();
            Assert.Equal(emp.Name, expected.Name);
        }
        [Fact]
        public void Next_ShouldReturn_NextEmployee()
        {
            collection.AddEmployee(new Elempoyee("Lavanya", 100));
            collection.AddEmployee(new Elempoyee("Tereena", 101));
            Iterator iterator = collection.CreateIterator();
            Elempoyee emp = iterator.Next();
            Assert.Equal("Tereena", emp.Name);
           
        }

    }
}
