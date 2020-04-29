using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");

            Console.WriteLine("enter the type of engine you want");
            string engine = Console.ReadLine();
            switch (engine.ToLower())
               {
                case "petrolengine":
                    PetrolCarDecorator carwithPetrolEngine = new PetrolCarDecorator(bmwCar1);
                    carwithPetrolEngine.ManufactureCar();
                    break;
                case "dieselengine":
                    DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
                    carWithDieselEngine.ManufactureCar();
                    break;

                default:
                    break;
                }
            Console.ReadKey();
        }
    }
}


