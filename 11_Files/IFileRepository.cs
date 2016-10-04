namespace _11_Files
{
    internal interface IFileRepository
    {
        string StockFileName(int stockName);
        string StockFileName(Stock stockName);
        void SaveStock(Stock item);
    }
}