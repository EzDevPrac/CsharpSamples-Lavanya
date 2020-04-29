using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class CatFactory:AnimalFactory
    {
        protected override Animal MakeAnimal()
        {
            Animal animal = new Cat();
            return animal;
        }
    }
    class DogFactory : AnimalFactory
    {
        protected override Animal MakeAnimal()
        {
            Animal animal = new Dog();
            return animal;
        }
    }
}
