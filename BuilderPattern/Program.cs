using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
             Beverage beverage;
             BeverageDirector beverageDirector = new BeverageDirector();

             Tea tea = new Tea();
             beverage = beverageDirector.MakeBeverage(tea);
             Console.WriteLine(beverage.ShowBeverage());
             Coffee coffee = new Coffee();
             beverage = beverageDirector.MakeBeverage(coffee);
             Console.WriteLine(beverage.ShowBeverage());
             Console.ReadLine();

        }
    }
}
