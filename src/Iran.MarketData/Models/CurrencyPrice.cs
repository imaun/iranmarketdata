using System;
using System.Collections.Generic;
using System.Text;

namespace Iran.MarketData
{
    public class CurrencyPrice
    {
        public string Title { get; set; }
        public string Symbol { get; set; }
        public int PriceValue { get; set; }
        public string PriceDisplay => PriceValue.ToString("N0");
    }
}
