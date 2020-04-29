using System;
using Xunit;

namespace StrategyPattern.Testing
{
    public class TravelTest
    {

        [Fact]
        public void BusTravel_ShouldReturn_StringSayingModeAndCost()
        {
            ITravelStrategy bus = new BusTravelStrategy();
            Assert.Equal("Traveler is going to Airport by bus and will be charged Rs 300", bus.GotoAirport());
            
        }
        [Fact]
        public void TaxiTravel_ShouldReturn_StringSayingModeAndCost()
        {
            ITravelStrategy bus = new TaxiTravelStrategy();
            Assert.Equal("Traveler is going to Airport by Taxi and will be charged Rs 1000", bus.GotoAirport());

        }
        [Fact]
        public void TrainTravel_ShouldReturn_StringSayingModeAndCost()
        {
            ITravelStrategy bus = new TrainTravelStrategy();
            Assert.Equal("Traveler is going to Airport by Train and will be charged Rs 200", bus.GotoAirport());

        }
        [Fact]
        public void AutoTravel_ShouldReturn_StringSayingModeAndCost()
        {
            ITravelStrategy bus = new AutoTravelStrategy();
            Assert.Equal("Traveler is going to Airport by Auto and will be charged Rs 600", bus.GotoAirport());

        }
    }
}
