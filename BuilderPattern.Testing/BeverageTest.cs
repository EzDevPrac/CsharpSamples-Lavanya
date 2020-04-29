using BuilderPattern;
using System;
using Xunit;

namespace BuilderPattern.Testing
{
    public class BeverageTest
    {
        [Fact]
        public void CoffeeSetWater_ShouldReturn_Step1BoilingWater()
        {
            Coffee cof = new Coffee();
            cof.CreateBeverage();
            string str = cof.SetWater();
            Assert.Equal("Step 1 : Boiling water", str);
        }
        [Fact]
        public void CoffeeSetMilk_ShouldReturn_Step2AddingMilk()
        {
            Coffee cof = new Coffee();
            cof.CreateBeverage();
            string str = cof.SetMilk();
            Assert.Equal("Step 2 : Adding milk", str);
        }
        [Fact]
        public void CoffeeSetsugar_ShouldReturn_Step3AddingSugar()
        {
            Coffee cof = new Coffee();
            cof.CreateBeverage();
            string str = cof.SetSugar();
            Assert.Equal("Step 3 : Adding Sugar", str);
        }
        [Fact]
        public void CoffeeSetpowder_ShouldReturn_Step4Adding15GramsOfPowder()
        {
            Coffee cof = new Coffee();
            cof.CreateBeverage();
            string str = cof.SetPowderQuantity();
            Assert.Equal("Step 4 : Adding 15 Grams of coffee powder", str);
        }
        [Fact]
        public void CoffeeSetBevergeName_ShouldReturn_Coffee()
        {
            Coffee cof = new Coffee();
            cof.CreateBeverage();
            string str = cof.SetBeverageType();
            Assert.Equal("Coffee", str);
        }

        [Fact]
        public void TeaSetWater_ShouldReturn_Step1BoilingWater()
        {
            Tea tea = new Tea();
            tea.CreateBeverage();
            string str = tea.SetWater();
            Assert.Equal("Step 1 : Boiling water", str);
        }
        [Fact]
        public void TeaSetMilk_ShouldReturn_Step2AddingMilk()
        {
            Tea tea = new Tea();
            tea.CreateBeverage();
            string str = tea.SetMilk();
            Assert.Equal("Step 2 : Adding milk", str);
        }
        [Fact]
        public void TeaSetsugar_ShouldReturn_Step3AddingSugar()
        {
            Tea tea = new Tea();
            tea.CreateBeverage();
            string str = tea.SetSugar();
            Assert.Equal("Step 3 : Adding Sugar", str);
        }
        [Fact]
        public void TeaSetpowder_ShouldReturn_Step4Adding15GramsOfPowder()
        {
            Tea tea = new Tea();
            tea.CreateBeverage();
            string str = tea.SetPowderQuantity();
            Assert.Equal("Step 4 : Adding 20 Grams of tea powder", str);
        }
        [Fact]
        public void TeaSetBevergeName_ShouldReturn_Tea()
        {
            Tea tea = new Tea();
            tea.CreateBeverage();
            string str = tea.SetBeverageType();
            Assert.Equal("Tea", str);
        }
    }
}
