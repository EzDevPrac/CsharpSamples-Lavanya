using System;

namespace Problem3
{
    class ShapeTest
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(2);
            Console.WriteLine("area of circle " + c.Area() + "Perimeter of circle " + c.Perimeter());
            Rectangle rectangle = new Rectangle(3, 4);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("Area of rectangle"+rectangle.Area()+" perimeter of rectangle"+rectangle.Perimeter());
            Square square = new Square(10, 5, 7);
            Console.WriteLine(square.ToString());
            Console.WriteLine("Area of Square" + square.Area() + " perimeter of Square" +square.Perimeter());


        }
    }
}
