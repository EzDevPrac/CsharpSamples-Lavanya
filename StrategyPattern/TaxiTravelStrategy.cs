using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
        public class TaxiTravelStrategy : ITravelStrategy
        {
            public string GotoAirport()
            {
                Console.WriteLine("Traveler is going to Airport by Taxi and will be charged Rs 1000");

                return "Traveler is going to Airport by Taxi and will be charged Rs 1000";
            }
        }
}
