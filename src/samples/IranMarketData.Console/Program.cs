using System;
using Iran.MarketData;

namespace IranMarketData.Console
{
    class Program
    {
        static void Main(string[] args) {
            System.Console.WriteLine("Hello World!");

            var service = new IranMarketDataService();

            var result = service.FiatCurrency.GetUsdPrice();

            if(result != null) {
                System.Console.WriteLine($"USD price : {result.PriceDisplay}");
            }

            System.Console.ReadLine();
        }
    }
}
