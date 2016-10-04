using System;
using System.IO;

namespace _11_Files
{
    internal class StockIO
    {
        public StockIO()
        {
        }

        internal void WriteStock(StringWriter sw, Stock stockName)
        {
            sw.WriteLine(stockName.Symbol);
            sw.WriteLine(stockName.PricePerShare);
            sw.WriteLine(stockName.NumShares);

        }

        internal Stock ReadStock(StringReader data)
        {
            Stock stock = new Stock();
            stock.Symbol = data.ReadLine();
            stock.PricePerShare = double.Parse(data.ReadLine());
            stock.NumShares = double.Parse (data.ReadLine());
           return stock;
        }
    }
}