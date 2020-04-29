using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            Console.WriteLine("Enter the animal you want to create :");

            string ani = Console.ReadLine();
            switch (ani.ToLower())
            {
                case "cat": 
                    animal = new CatFactory().CreateAnimal();
                    break;
                case "dog":
                    animal = new DogFactory().CreateAnimal();
                    break;
                default:
                    break;
            }
            if (animal != null)
            {
                Console.WriteLine("Animal Type : " + animal.GetType().Name);
                Console.WriteLine(animal.GetType().Name + " Speak : " + animal.speak());
                Console.WriteLine(animal.GetType().Name + " Dance like : " + animal.dance());

            }
            else
            {
                Console.Write("Invalid Animal Type");
            }
            Console.ReadLine();
        }
    }
}
