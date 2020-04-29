using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
     abstract class AnimalFactory
    {
        protected abstract Animal MakeAnimal();
        public Animal CreateAnimal()
        {
            return this.MakeAnimal();
        }
    }
}

