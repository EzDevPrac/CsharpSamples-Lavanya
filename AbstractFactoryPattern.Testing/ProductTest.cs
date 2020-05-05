using System;
using Xunit;

namespace AbstractFactoryPattern.Testing
{
    public class ProductTest
    {
        [Fact]
        public void SnickersDetails_ShouldReturn_NameAndCost()
        {
            Snickers sn = new Snickers();
            Assert.Equal("Name : Snickers , cost : Rs 20", sn.ProductDetails());
        }
        [Fact]
        public void KitkatDetails_ShouldReturn_NameAndCost()
        {
            KitKat kit = new KitKat();
            Assert.Equal("Name : KitKat ,Cost : Rs 10", kit.ProductDetails());
        }
        [Fact]
        public void VanillaDreamDetails_ShouldReturn_NameAndCost()
        {
            VanillaDream vn = new VanillaDream();
            Assert.Equal("Name : Vanilla Dream, Cost :Rs 75", vn.ProductDetails());
        }
        [Fact]
        public void SwisChocolateDetails_ShouldReturn_NameAndCost()
        {
            SwisChocolate swisChocolate = new SwisChocolate();
            Assert.Equal("Name : Swis Chocolate , Cost : Rs 110", swisChocolate.ProductDetails());
        }
    }
}
