using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{  
    public class BusTravelStrategy : ITravelStrategy
    {
            public string GotoAirport()
            {
                Console.WriteLine("Traveler is going to Airport by bus and will be charged Rs 300");

                  return "Traveler is going to Airport by bus and will be charged Rs 300";
            }
    }
}

