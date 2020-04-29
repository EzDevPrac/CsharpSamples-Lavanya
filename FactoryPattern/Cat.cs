using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{

    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow";
        }
        public string dance()
        {
            return "Dam Dam";
        }
    }

}
