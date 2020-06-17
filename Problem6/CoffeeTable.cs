using System;
using System.Collections.Generic;
using System.Text;

namespace Problem6
{
   public class CoffeeTable :Table
    {
        public CoffeeTable(double Width, double Heigth):base(Width, Heigth)
        {
         
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Coffeetable Width: {0}, Heigth: {1}",GetWidth(), GetHeigth());
        }
    }
}
