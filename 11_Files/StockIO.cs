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

        internal void WriteStock(FileInfo output, Stock hp)
        {
            string NL = Environment.NewLine;
            StreamWriter sw = output.CreateText();
            sw.WriteLine(hp.Symbol + NL + hp.PricePerShare + NL + hp.NumShares);
            sw.Close();
            
        }

        internal Stock ReadStock(FileInfo output)
        {
            StreamReader sr = output.OpenText();
            Stock stock = new Stock();
            stock.Symbol = sr.ReadLine();
            stock.PricePerShare = double.Parse(sr.ReadLine());
            stock.NumShares = double.Parse(sr.ReadLine());
            sr.Close();
            return stock;
        }
    }
}