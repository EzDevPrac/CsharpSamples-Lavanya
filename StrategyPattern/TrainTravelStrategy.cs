using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
        public class TrainTravelStrategy : ITravelStrategy
        {
            public string GotoAirport()
            {
                Console.WriteLine("Traveler is going to Airport by Train and will be charged Rs 200");

            return "Traveler is going to Airport by Train and will be charged Rs 200";
            }
        }
}
