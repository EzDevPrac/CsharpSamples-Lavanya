using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
  public  class Dog:Animal
    {
        public string speak()
        {
            return "Bark Bark";
        }
        public string dance()
        {
            return "Ba Ba";
        }
    }
}
