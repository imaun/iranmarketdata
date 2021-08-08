using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace Iran.MarketData
{
    public class FiatCurrencyService
    {

        private const string _dollarSource = @"https://www.tgju.org/profile/price_dollar_rl";

        public CurrencyPrice GetUsdPrice() {
            var web = new HtmlWeb();
            var doc = new HtmlDocument();
            doc = web.Load(_dollarSource);

            foreach(var item in doc.DocumentNode.SelectNodes("//span[@data-col]")) {
                var value = item.GetAttributeValue("data-col", "");
                if (string.IsNullOrWhiteSpace(value))
                    continue;

                if(value.ToLower() == "info.last_trade.pdrcotval") {
                    var priceText = item.InnerText.Replace(",", "");
                    var price = int.Parse(priceText);
                    return new CurrencyPrice {
                        PriceValue = price,
                        Symbol = "USD",
                        Title = "دلار"
                    };

                }
            }

            return null;
        }

    }
}
