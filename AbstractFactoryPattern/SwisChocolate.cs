using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
   public class SwisChocolate :IFood
    {
        public string ProductDetails()
        {
            return "Name : Swis Chocolate , Cost : Rs 110";
        }
    }
}
