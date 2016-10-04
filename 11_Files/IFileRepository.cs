namespace _11_Files
{
    internal interface IFileRepository
    {
        string StockFileName(long stockName);
        string StockFileName(Stock stockName);
        void SaveStock(Stock item);
    }
}