using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            double result = 3.14 * Radius * Radius;
            return result;
        }

        public override double Perimeter()
        {
            double result = 2 * 3.14 * Radius;
            return result;
        }
    }
}
