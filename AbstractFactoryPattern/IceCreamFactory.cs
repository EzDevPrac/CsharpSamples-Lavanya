using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
   public class IceCreamFactory : FoodFactory
    {
        public override IFood GetProduct(string FoodType)
        {
            if (FoodType.Equals("Vanilla Dream"))
            {
                return new VanillaDream();
            }
            else
            {
                return new SwisChocolate();
            }

        }
    }
}
