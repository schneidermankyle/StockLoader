using System;
using System.IO;
using System.Net;

namespace StockLoader {
    public static class GetIndices {

        // Parse our response from the web server.
        private static string getList(HttpWebResponse response) {
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string webPageInfo = reader.ReadToEnd();

            int index = webPageInfo.IndexOf("\"symbols\"");
            if (index != -1) {
                webPageInfo = webPageInfo.Substring(index + 9);
            }

            index = webPageInfo.IndexOf("=\"");
            if (index != -1) {
                webPageInfo = webPageInfo.Substring(index + 2);
            }

            index = webPageInfo.IndexOf(",,");
            if (index != -1) {
                webPageInfo = webPageInfo.Substring(0, index);
            }

            index = webPageInfo.IndexOf("\"");
            if (index != -1) {
                webPageInfo = webPageInfo.Substring(0, index);
            }

            webPageInfo = webPageInfo.Replace(",", ", ");
            return webPageInfo;
        }

        // Make our web request for the list of indicies then parse the response.
        public static string GetStockList(string index) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://old.barchart.com/stocks/"+ index +".php");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            return getList(response);
        }

    }
}
