using System;
using Xunit;
using FactoryPattern;
namespace FactoryPattern.Testing
{
    public class FactoryPatternTest
    {
        [Fact]
        public void CatSpeak_ShouldReturn_Meow_Meow()
        {
            //Arrange
            Cat cat = new Cat();
            //Act
            string str = cat.speak();
            //Assert
            Assert.Equal("Meow Meow", str);

        }
        [Fact]
        public void CatDance_ShouldReturn_Dam_Dam()
        {
            //Arrange
            Cat cat = new Cat();
            //Act
            string str = cat.dance();
            //Assert
            Assert.Equal("Dam Dam", str);
        }
        [Fact]
        public void DogSpeak_ShouldReturn_Bark_Bark()
        {
            //Arrange
            Dog dog = new Dog();
            //Act
            string str = dog.speak();
            //Assert
            Assert.Equal("Bark Bark", str);

        }
        [Fact]
        public void CatDance_ShouldReturn_Ba_Ba()
        {
            //Arrange
            Dog dog = new Dog();
            //Act
            string str = dog.dance();
            //Assert
            Assert.Equal("Ba Ba", str);
        }

    }
}
