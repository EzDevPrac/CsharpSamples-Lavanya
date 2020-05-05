using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFood food = null;
            FoodFactory foodFactory = null;
            string Details = null;
            foodFactory = FoodFactory.CreateFoodFactory("Ice Cream");
            Console.WriteLine("Food Factory type : " + foodFactory.GetType().Name);
            Console.WriteLine();

            food = foodFactory.GetProduct("Vanilla Dream");
            Details = food.ProductDetails();
            Console.WriteLine(Details);

            Console.WriteLine("--------------------------------------------");

            foodFactory = FoodFactory.CreateFoodFactory("Chocolate");
            Console.WriteLine("Food Factory type : " + foodFactory.GetType().Name);
            Console.WriteLine();

            food = foodFactory.GetProduct("Snickers");
            Details = food.ProductDetails();
            Console.WriteLine(Details);








        }
    }
}
