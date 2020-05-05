using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
     
        public abstract class FoodFactory
    {
            public abstract IFood GetProduct(string FoodType);
            public static FoodFactory CreateFoodFactory(string FactoryType)
            {
            if (FactoryType.Equals("Ice Cream"))
                return new IceCreamFactory();
            else
                return new ChocolateFactory();
            }
        }
    
}
