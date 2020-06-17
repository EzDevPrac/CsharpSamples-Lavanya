using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
   public abstract class Shape
    {
        public Location location;
       /* public override string ToString()
        {
            return "";
        }*/
        public abstract double Area();
        public abstract double Perimeter();
    }
}
