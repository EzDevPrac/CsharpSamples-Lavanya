using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
   public class KitKat : IFood
    {
        public string ProductDetails()
        {
            return "Name : KitKat ,Cost : Rs 10";
        }
    }
}
