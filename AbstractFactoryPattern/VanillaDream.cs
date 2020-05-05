using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
   public class VanillaDream : IFood
    {
        public string ProductDetails()
        {
            return "Name : Vanilla Dream, Cost :Rs 75";
        }
    }
}
