using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
     public class Person
    {
        protected int age { set; get; }

         public void SetAge(int n)
        {
            age = n;
        }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
