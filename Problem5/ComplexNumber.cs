using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
   public class ComplexNumber
    {

        private int Real { get; set; }
        private int Imaginary { get; set; }

        public ComplexNumber(int real, int imag)
        {
            Real = real;
            Imaginary = imag;
        }
        public int GetReal()
        {
            return Real;
        }
        public void SetReal(int n)
        {
            Real = n;
        }
        public int GetImaginary()
        {
            return Imaginary;
        }
        public void SetImag(int n)
        {
            Imaginary = n;
        }
        public override string ToString()
        {
            return "(" + Real + "," + Imaginary + ")";
        }
        public double GetMagnitude()
        {
            double result = Math.Sqrt((Real * Real + Imaginary * Imaginary));
            return result;
        }
        public void AddComplex(ComplexNumber number)
        {

            Real += number.GetReal();
            Imaginary += number.GetImaginary();
          
        }
        public static ComplexNumber operator +(ComplexNumber number1 , ComplexNumber number2)
        {
            int a = number1.GetReal() + number2.GetReal();
            int b = number1.GetImaginary() + number2.GetImaginary();
            return new ComplexNumber(a, b);
        }
        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            int a = number1.GetReal() - number2.GetReal();
            int b = number1.GetImaginary() - number2.GetImaginary();
            return new ComplexNumber(a, b);
        }


    }
}
