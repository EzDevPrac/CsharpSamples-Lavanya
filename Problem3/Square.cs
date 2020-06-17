using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    class Square:Shape
    {
        public double side;
        Location l = new Location();

        public Square(double x , double y,double side )
        {
            l.SetX(x);
            l.SetY(y);
            this.side = side;

        }

        public override double Area()
        {
            double result = side * side;
            return result;
        }

        public void Move(double x , double y)
        {
            l.SetX(x);
            l.SetY(y);
        }

        public override double Perimeter()
        {
            double result = 4 * side;
            return result;
        }

        public void Scale (int num)
        {
            side = side * num;
        }
        public override string ToString()
        {
            return "Corner (" + l.GetX() + "," + l.GetY() + ")" + " side" + side;
        }
    }
}
