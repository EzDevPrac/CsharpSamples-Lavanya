using System;
namespace BuilderPattern
{
    public class Tea : BeverageBuilder
    {
        public override string SetWater()
        {
            GetBeverage().Water = 50;
            return "Step 1 : Boiling water";
        }
        public override string SetMilk()
        {
            GetBeverage().Milk = 60;
            return "Step 2 : Adding milk";
        }
        public override string SetSugar()
        {
            GetBeverage().Sugar = 15;
            return "Step 3 : Adding Sugar";
        }
        public override string SetPowderQuantity()
        {
            GetBeverage().PowderQuantity = 20;
            return "Step 4 : Adding 20 Grams of tea powder";
        }
        public override string SetBeverageType()
        {
             GetBeverage().BeverageName = "Tea";
            return "Tea";
        }
    }
}