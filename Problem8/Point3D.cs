using System;
using System.Collections.Generic;
using System.Text;

namespace Problem8
{
     public class Point3D
     {
        private double x, y, z;
        public Point3D(double x, double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void SetX(double n)
        {
            x = n;

        }
        public double GetX()
        {
            return x;
        }
        public void SetY(double n)
        {
            y = n;

        }
        public double GetY()
        {
            return y;
        }
        public void SetZ(double n)
        {
            z = n;

        }
        public double GetZ()
        {
            return z;
        }
        public void MoveTO(double num1, double num2,double num3 )
        {
            SetX(num1);
            SetY(num2);
            SetZ(num3);

        }
        public override string ToString()
        {
            return "(" + GetX() + "," + GetY() + "," + GetZ() + ")";
        }
        public double DistanceTo(Point3D p2)
        {
            return Math.Sqrt((x - p2.GetX()) * (x - p2.GetX()) +
              (y - p2.GetY()) * (y - p2.GetY()) +
              (z - p2.GetZ()) * (z - p2.GetZ()));
        }
    }
}
