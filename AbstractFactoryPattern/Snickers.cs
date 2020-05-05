using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Snickers : IFood
    {
      public  string ProductDetails()
        {
            return "Name : Snickers , cost : Rs 20";
        }

    }
}
