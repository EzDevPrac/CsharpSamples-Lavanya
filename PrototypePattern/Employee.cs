using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }
        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }

    }
    
}
