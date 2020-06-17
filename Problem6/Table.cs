using System;
using System.Collections.Generic;
using System.Text;

namespace Problem6
{
  public class Table
    {
        private double width;
        private double height;
        public Table(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public void SetWidth(double wid)
        {
            width = wid;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetHeigth(double height)
        {
            this.height = height;
        }
        public double GetHeigth()
        {
            return height;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine(" Table Width: {0}, Heigth: {1}", width, height);
        }
    }
}
