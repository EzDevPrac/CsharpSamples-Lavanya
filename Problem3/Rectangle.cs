using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class Rectangle : Shape
    {
        public double Side1;
        public double Side2;

        public Rectangle( double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public override double Area()
        {
            double result = Side1 * Side2;
            return result;
        }

        public override double Perimeter()
        {
            double result = 2 * Side1 * 2 * Side2;
            return result;
        }
    }
}
