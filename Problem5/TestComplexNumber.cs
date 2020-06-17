using System;

namespace Problem5
{
     class TestComplexNumber
    {
        static void Main(string[] args)
        {
            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine("Number is: " + number.ToString());

            number.SetImag(-3);
            Console.WriteLine("Number is: " + number.ToString());

            Console.Write("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());

            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.AddComplex(number2);
            Console.Write("After adding: ");
            Console.WriteLine(number.ToString());

        }
    }
}
