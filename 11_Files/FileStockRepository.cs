using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository, IFileRepository
    {
        StockIO stockio = new StockIO();
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

        public string StockFileName(long stockName)
        {
            return "stock" + stockName + ".txt" ;
        }
        public string StockFileName(Stock stockName)
        {
            return "stock" + stockName.Id + ".txt";
        }

        public void SaveStock(Stock item)
        {
            item.Id = NextId();
            string path = repositoryDir + StockFileName(item);
            stockio.WriteStock(new FileInfo(path), item);
        }

        public Stock LoadStock(long id)
        {
            string path = repositoryDir + StockFileName(id);
            return stockio.ReadStock(new FileInfo(path));
        }

        public void Clear()
        {
            foreach (FileInfo item in repositoryDir.GetFiles())
            {
                item.Delete();
            }
        }

        public ICollection FindAllStocks()
        {
            string[] filepath = Directory.GetFiles(repositoryDir.ToString());
            List<Stock> filelist = new List<Stock>();
            FileInfo fileinfo;

            foreach (string file in filepath)
            {
                fileinfo = new FileInfo(file);
                filelist.Add(stockio.ReadStock(fileinfo));
            }
            return filelist;
        }
    }
}