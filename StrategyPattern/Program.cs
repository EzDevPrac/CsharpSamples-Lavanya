using System;

namespace StrategyPattern
{
   public class Program
    {
        static void Main(string[] args)
        {
            TravelContext travel = new TravelContext();
            Console.WriteLine("Please enter Travel Type : Auto or Bus or Train or Taxi");
            string input = Console.ReadLine();
            switch(input.ToLower())
            {
                case "bus": travel.SetTravelStrategy(new BusTravelStrategy());
                    break;
                case "train": travel.SetTravelStrategy(new TrainTravelStrategy());
                    break;
                case "taxi": travel.SetTravelStrategy(new TaxiTravelStrategy());
                    break;
                case "auto": travel.SetTravelStrategy(new AutoTravelStrategy());
                    break;
                default:
                    break;
            }
            travel.gotoAirport();
            Console.ReadLine();
        }
    }
}
