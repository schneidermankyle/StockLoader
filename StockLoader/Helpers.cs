using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace StockLoader {
    public static class Helpers {
        public static string[] SplitTickers(string tickers) {
            tickers = tickers.Replace(" ", String.Empty);
            tickers = tickers.ToUpper();
            return tickers.Split(',');
        }

        public static void DownloadSymbolsToCSV(string url, string path, string folder, string symbol) {
            using (WebClient Client = new WebClient()) {
                Client.DownloadFile(url, path);

                string tempFile = Path.Combine(folder, symbol + "_temp.csv");
                using (var writer = new StreamWriter(tempFile))
                using (var reader = new StreamReader(File.OpenRead(path))) {
                    string header = reader.ReadLine();
                    header = header.Insert(0, "Ticker");
                    header = header.Replace("Adj Close", "Adj_Close");
                    writer.WriteLine(header);

                    while (!reader.EndOfStream) {
                        string tickerInfo = reader.ReadLine();
                        tickerInfo = tickerInfo.Insert(0, symbol + ",");
                        writer.WriteLine(tickerInfo);
                    }
                }
                File.Copy(tempFile, path, true);
                File.Delete(tempFile);
            }
        }
    }
}
