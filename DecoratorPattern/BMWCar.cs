using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";
        public string CarBody { get; set; }
        public string CarDoor { get; set; }
        public string CarWheels { get; set; }
        public string CarGlass { get; set; }
        public string Engine { get; set; }
        public override string ToString()
        {
            return "\n CarName=" + CarName + "\n CarBody=" + CarBody + "\n CarDoor=" + CarDoor + "\n CarWheels="
                            + CarWheels + "\n CarGlass=" + CarGlass + "\n Engine=" + Engine;
        }
        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarWheels ="4 MRF wheels";
            CarGlass = "6 car glasses";
            return this;
        }
        public string DisplayEngineDetails()
        {
            return Engine;
        }
    }
}
