namespace BuilderPattern
{
    public class Beverage
    {
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int PowderQuantity { get; set; }
        public string BeverageName { get; set; }
        
        public string ShowBeverage()
        {
            return "Hot " + BeverageName + " [" + Water + " ml of water, " + Milk + "ml of milk, " + Sugar
                            + " gm of sugar, " + PowderQuantity + " gm of " + BeverageName + "]\n";
        }
    }
}