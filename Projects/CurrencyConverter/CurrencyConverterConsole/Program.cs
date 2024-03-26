using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        // Konsol ba�l���n� ayarla
        Console.Title = "D�viz Bilgileri Uygulamas�";

        // Ana d�ng�, kullan�c�n�n se�eneklerini g�steren bir men� sunar ve kullan�c� giri�lerini i�ler
        while (true)
        {
            Console.Clear();
            Console.WriteLine("D�viz Bilgileri Uygulamas�na Ho� Geldiniz!");
            Console.WriteLine("Hangi d�viz bilgisini g�rmek istersiniz?");
            Console.WriteLine("0. T�m D�vizleri G�ster");
            Console.WriteLine("1. ABD Dolar�");
            // ... Di�er d�viz se�eneklerini ekleyin ...

            Console.Write("Se�iminizi yap�n: ");
            string kullaniciGirisi = Console.ReadLine();

            // Kullan�c�n�n giri�ini kontrol et ve uygun i�lemleri ger�ekle�tir
            if (int.TryParse(kullaniciGirisi, out int secim))
            {
                switch (secim)
                {
                    case 0:
                        // T�m d�viz bilgilerini g�ster
                        Console.Clear();
                        Console.WriteLine("T�m D�viz Bilgileri\n");

                        foreach (string dovizIsim in DovizIsimleri)
                        {
                            Doviz doviz = DovizBilgisiniGetir(dovizIsim);
                            Console.WriteLine($"{dovizIsim}: Al��: {doviz.Alis}, Sat��: {doviz.Satis}");
                        }
                        break;
                    case 99:
                        // Uygulamadan ��k��
                        Console.WriteLine("Uygulamadan ��k�l�yor...");
                        return;
                    default:
                        if (secim > 0 && secim <= DovizIsimleri.Length)
                        {
                            // Belirli bir d�vizin bilgilerini g�ster
                            string secilenDoviz = DovizIsimleri[secim - 1];
                            Doviz doviz = DovizBilgisiniGetir(secilenDoviz);

                            Console.Clear();
                            Console.WriteLine($"{secilenDoviz} D�vizi Bilgileri\n");
                            Console.WriteLine($"Al��: {doviz.Alis}, Sat��: {doviz.Satis}");
                        }
                        else
                        {
                            // Ge�ersiz se�im durumu
                            Console.WriteLine("Ge�ersiz se�im. L�tfen do�ru bir se�enek girin.");
                        }
                        break;
                }
            }
            else
            {
                // Ge�ersiz giri� durumu
                Console.WriteLine("Ge�ersiz giri�. L�tfen bir say� girin.");
            }

            // Kullan�c�ya devam etmek i�in bir tu�a basmas� hat�rlat�l�r
            Console.WriteLine("\nDevam etmek i�in bir tu�a bas�n...");
            Console.ReadKey();
        }
    }

    // D�viz isimleri i�in bir dizi
    private static string[] DovizIsimleri =
    {
        "ABD Dolar�", "Euro", "�ngiliz Sterlini", "Kanada Dolar�", "�svi�re Frang�",
        "Rus Rublesi", "Suudi Arabistan Riyali", "Japon Yeni", "Avustralya Dolar�",
        "Norve� Kronu", "Danimarka Kronu", "�sve� Kronu"
    };

    // Se�ilen d�vizin bilgilerini getiren metot
    public static Doviz DovizBilgisiniGetir(string dovizIsim)
    {
        // Hedef URL
        string url = "https://uzmanpara.milliyet.com.tr/doviz-kurlari/";

        // Web sayfas�n� indir
        string htmlIcerik;
        using (WebClient client = new WebClient())
        {
            htmlIcerik = client.DownloadString(url);
        }

        // HtmlAgilityPack belge olu�tur
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(htmlIcerik);

        // Se�ilen d�viz bilgisini getir
        int satir = Array.IndexOf(DovizIsimleri, dovizIsim) + 1;
        Doviz doviz = new Doviz();
        doviz.Alis = DovizBilgisiniGetir(doc, satir, 3);
        doviz.Satis = DovizBilgisiniGetir(doc, satir, 4);

        return doviz;
    }

    // Belirtilen XPath ile d�viz bilgisini getiren yard�mc� metot
    private static string DovizBilgisiniGetir(HtmlDocument doc, int satir, int sutun)
    {
        // XPath olu�tur
        string xpath = $"/html/body/div[13]/div[6]/div[2]/div[1]/table/tbody/tr[{satir}]/td[{sutun}]";

        // XPath ile belirli bir elementi se�
        var element = doc.DocumentNode.SelectSingleNode(xpath);

        // E�er element bulunursa, i�eri�i al, aksi halde bo� bir string d�nd�r
        return element?.InnerText.Trim() ?? string.Empty;
    }
}

// D�viz s�n�f�
public class Doviz
{
    public string Alis { get; set; }
    public string Satis { get; set; }
}