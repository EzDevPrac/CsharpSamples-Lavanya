using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
   public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm Going to Class");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is : {0} years old "+age);
        }
    }
}
