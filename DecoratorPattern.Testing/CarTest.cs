using System;
using Xunit;

namespace DecoratorPattern.Testing
{
    public class CarTest
    {
        [Fact]
        public void Manufacture_ShouldRetuen_DetailsOfCar()
        {
            ICar bmwCar1 = new BMWCar();
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            string str = carWithDieselEngine.ManufactureCar().ToString();
            string temp = bmwCar1.ToString();
            Assert.Equal(str, temp);
        }
    }
}
