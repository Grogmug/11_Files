namespace _11_Files
{
    internal class Stock : IAsset
    {
        public string Symbol
        {
            get;
            set;
        }

        public double PricePerShare
        {
            get;
            set;
        }

        public double NumShares
        {
            get;
            set;
        }
        public long Id
        {
            get;
            set;
        }

        public double GetValue()
        {
            return PricePerShare * NumShares;
        }
        public Stock()
        {

        }

        public Stock(string symbol, double pricePerShare, double numShares)
        {
            Symbol = symbol;
            PricePerShare = pricePerShare;
            NumShares = numShares;
        }

        public static double TotalValue(IAsset[] stocks)
        {
            double fullValue = 0;
            foreach (IAsset stock in stocks)
            {
                fullValue += stock.GetValue();
            }
            return fullValue;
        }

        public override string ToString()
        {
            return "Stock[symbol="+ Symbol + ",pricePerShare="+ PricePerShare.ToString().Replace(',','.') + ",numShares="+ NumShares +"]";
        }

        public override bool Equals(object obj)
        {
            Stock s = (Stock)obj;
            if (ToString() == s.ToString() )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string GetName()
        {
            return Symbol;
        }
    }
}