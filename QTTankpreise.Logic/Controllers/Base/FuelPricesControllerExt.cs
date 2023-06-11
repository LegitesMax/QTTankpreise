using HtmlAgilityPack;
using QTTankpreise.Logic.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTTankpreise.Logic.Controllers.Base
{
    partial class FuelPricesController
    {

        public List<FuelPrice> GetFuelPrices(string location, string radius, string fuel, string country = "at")
        {
            var url = $"https://www.benzinpreis-blitz.de/?land=" + country + "&suchfeld=" + location + "&entfernung=" + radius + "&sorte=" + fuel + "&sortierung=preis";
            var entity = new List<FuelPrice>();

            var web = new HtmlWeb();
            var document = web.Load(url);

            var brand = document.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div[3]/a/span[1]");
            var price = document.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div[3]/a/span[2]");
            var distance = document.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div[3]/a/div[4]");

            entity.Add(
                new FuelPrice
                {
                    CompanyName = brand.InnerHtml == null ? "Leider konnte nichts gefunden werden" : brand.InnerHtml,
                    PriceStatus = Modules.Common.PriceStatus.BestPrice,
                    Price = price.InnerHtml == null ? 0 : double.Parse(price.InnerHtml.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture),
                    Distance = distance.InnerHtml == null ? "0" : distance.InnerHtml,
                });

            brand = document.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div[4]/a/span[1]");
            price = document.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div[4]/a/span[2]");
            distance = document.DocumentNode.SelectSingleNode("//*[@id=\"content\"]/div[4]/a/div[4]");

            entity.Add(
                new FuelPrice
                {
                    CompanyName = brand.InnerHtml == null ? "Leider konnte nichts gefunden werden" : brand.InnerHtml,
                    PriceStatus = Modules.Common.PriceStatus.NearestPrice,
                    Price = price.InnerHtml == null ? 0 : double.Parse(price.InnerHtml.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture),
                    Distance = distance.InnerHtml == null ? "0" : distance.InnerHtml,
                });

            return entity;
        }

    }
}
