using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
        public class ThirdPartyBillingSystem
        {
           
            public void ProcessSalary(List<Employee> listEmployee)
            {
                foreach (Employee employee in listEmployee)
                {
                    Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
                }
            }
        }
}
