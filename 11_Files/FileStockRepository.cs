using System;
using System.IO;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository, IFileRepository
    {
        private DirectoryInfo repositoryDir;
        public long id = 0;

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public long NextId()
        {
            id++;
            return id;
        }

        public string StockFileName(int stockName)
        {
            return "stock" + stockName + ".txt" ;
        }
        public string StockFileName(Stock stockName)
        {
            return "stock" + stockName.Id + ".txt";
        }

        public void SaveStock(Stock item)
        {
            
        }
    }
}