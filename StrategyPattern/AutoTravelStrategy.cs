using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
   public class AutoTravelStrategy : ITravelStrategy
        {
            public string GotoAirport()
            {
            Console.WriteLine("Traveler is going to Airport by Auto and will be charged Rs 600");

            return "Traveler is going to Airport by Auto and will be charged Rs 600";
            }
        }
}
