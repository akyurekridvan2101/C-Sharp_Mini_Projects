using System.Net;
using HtmlAgilityPack;
using System.Threading;

namespace CurrencyConverter
{
    internal static class Program
    {
        public static string[,] dovizBilgileri = new string[12, 4];

        public static int a = 0;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            DovizKurlari();


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());



        }

        public static void DovizKurlari()
        {
            string url = "https://bigpara.hurriyet.com.tr/doviz/";

            var webClient = new WebClient();
            string htmlContent = webClient.DownloadString(url);

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);

            for (int i = 1; i <= 12; i++)
            {
                var buyingPriceNodes = doc.DocumentNode.SelectNodes($"//div[@class='tBody']/ul[{i}]/li[3]");
                var sellingPriceNodes = doc.DocumentNode.SelectNodes($"//div[@class='tBody']/ul[{i}]/li[4]");
                var changeNodes = doc.DocumentNode.SelectNodes($"//div[@class='tBody']/ul[{i}]/li[5]");

                if (buyingPriceNodes != null && sellingPriceNodes != null && changeNodes != null)
                {
                    dovizBilgileri[i - 1, 0] = buyingPriceNodes[0].InnerText;// Alýþ Fiyatý
                    dovizBilgileri[i - 1, 1] = sellingPriceNodes[0].InnerText;// Satýþ Fiyatý
                    dovizBilgileri[i - 1, 2] = changeNodes[0].InnerText[0] == '-' ? changeNodes[0].InnerText : ("+" + changeNodes[0].InnerText);// Deðiþim
                }
            }
        }
    }
}
