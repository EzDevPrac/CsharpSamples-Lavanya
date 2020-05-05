using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ChocolateFactory : FoodFactory
    {
        public override IFood GetProduct(string FoodType)
        {
            if (FoodType.Equals("KitKat"))
            {
                return new KitKat();
            }
            else
            {
                return new Snickers();
            }

        }
    }
}

