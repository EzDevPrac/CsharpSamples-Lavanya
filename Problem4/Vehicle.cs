using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
     public class Vehicle
     {
        protected string Model { get; set; }
        protected string Year { get; set; }
        protected double Price { get; set; }

        public void SetModel(string model)
        {
            Model = model;
        }
        public void SetYear(string year)
        {
            Year = year;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }

        public void Strat()
        {

        }
        public void Stop()
        {

        }


    }
}
