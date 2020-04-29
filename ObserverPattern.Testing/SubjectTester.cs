using System;
using Xunit;

namespace ObserverPattern.Testing
{
    public class SubjectTester
    {
        Subject sb = new Subject("April", 10000, "Not Done");
        
        [Fact]
        public void RegisterObserver_ShouldReturn_employee_add_successfuly()
        {
            User us = new User("Lavanya", sb);
            Assert.Equal("employee add successfuly", sb.RegisterObserver(us));

        }
        [Fact]
        public void getSalaryStatus_ShouldReturn_Status()
        {
            Assert.Equal("Not Done", sb.getSalaryStatus());
        }
        [Fact]
        public void RemoveObserver_ShouldReturn_removed_successfuly()
        {
            User us = new User("Lavanya", sb);
            Assert.Equal("Removed successfully", sb.RemoveObserver(us));
        }

        [Fact]
        public void Update_ShouldReturn_Updated_sucess()
        {
            User us = new User("Lavanya", sb);
            Assert.Equal("Updated sucess", us.update("done"));

        }

    }
}
