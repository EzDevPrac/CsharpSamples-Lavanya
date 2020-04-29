namespace BuilderPattern
{
    public abstract class BeverageBuilder
    {
        protected Beverage beverage;
        
        public void CreateBeverage()
        {
            beverage = new Beverage();
        }
        public Beverage GetBeverage()
        {
            return beverage;
        }
        
        public abstract string SetBeverageType();
        public abstract string SetWater();
        public abstract string SetMilk();
        public abstract string SetSugar();
        public abstract string SetPowderQuantity();
    }
}