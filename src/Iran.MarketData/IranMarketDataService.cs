using System;

namespace Iran.MarketData
{
    public class IranMarketDataService
    {
        
        public IranMarketDataService() {
            FiatCurrency = new FiatCurrencyService();
        }


        public FiatCurrencyService FiatCurrency { get; set; }
        

    }
}
