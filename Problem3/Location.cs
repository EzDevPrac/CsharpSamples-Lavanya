using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Problem3
{
   public class Location
    {
        private double X { set; get; }
        private double Y { set; get; }
        public void SetX(double x)
        {
            X = x;
        }
        public void SetY(double y)
        {
            Y = y;
        }
        public double GetX()
        {
            return X;
        }
        public double GetY()
        {
            return Y;
        }
       

    }
}
