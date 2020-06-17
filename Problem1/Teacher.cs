using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
   public class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation Begins");
        }
    }
}
