using System;
namespace BuilderPattern
{
    public class Coffee : BeverageBuilder 
    {
        public override string SetWater()
        {
            GetBeverage().Water = 40;
            return "Step 1 : Boiling water";
        }
        public override string SetMilk()
        {
            GetBeverage().Milk = 50;
            return "Step 2 : Adding milk";
        }
        public override string SetSugar()
        {
            GetBeverage().Sugar = 10;
            return "Step 3 : Adding Sugar";
        }
        public override string SetPowderQuantity()
        {
           GetBeverage().PowderQuantity = 15;
            return "Step 4 : Adding 15 Grams of coffee powder";
        }
        public override string SetBeverageType()
        {
           GetBeverage().BeverageName = "Coffee";
            return "Coffee";
            
        }
    }
}