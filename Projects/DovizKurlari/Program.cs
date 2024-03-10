using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        // Konsol başlığını ayarla
        Console.Title = "Döviz Bilgileri Uygulaması";

        // Ana döngü, kullanıcının seçeneklerini gösteren bir menü sunar ve kullanıcı girişlerini işler
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Döviz Bilgileri Uygulamasına Hoş Geldiniz!");
            Console.WriteLine("Hangi döviz bilgisini görmek istersiniz?");
            Console.WriteLine("0. Tüm Dövizleri Göster");
            Console.WriteLine("1. ABD Doları");
            // ... Diğer döviz seçeneklerini ekleyin ...

            Console.Write("Seçiminizi yapın: ");
            string kullaniciGirisi = Console.ReadLine();

            // Kullanıcının girişini kontrol et ve uygun işlemleri gerçekleştir
            if (int.TryParse(kullaniciGirisi, out int secim))
            {
                switch (secim)
                {
                    case 0:
                        // Tüm döviz bilgilerini göster
                        Console.Clear();
                        Console.WriteLine("Tüm Döviz Bilgileri\n");

                        foreach (string dovizIsim in DovizIsimleri)
                        {
                            Doviz doviz = DovizBilgisiniGetir(dovizIsim);
                            Console.WriteLine($"{dovizIsim}: Alış: {doviz.Alis}, Satış: {doviz.Satis}");
                        }
                        break;
                    case 99:
                        // Uygulamadan çıkış
                        Console.WriteLine("Uygulamadan çıkılıyor...");
                        return;
                    default:
                        if (secim > 0 && secim <= DovizIsimleri.Length)
                        {
                            // Belirli bir dövizin bilgilerini göster
                            string secilenDoviz = DovizIsimleri[secim - 1];
                            Doviz doviz = DovizBilgisiniGetir(secilenDoviz);

                            Console.Clear();
                            Console.WriteLine($"{secilenDoviz} Dövizi Bilgileri\n");
                            Console.WriteLine($"Alış: {doviz.Alis}, Satış: {doviz.Satis}");
                        }
                        else
                        {
                            // Geçersiz seçim durumu
                            Console.WriteLine("Geçersiz seçim. Lütfen doğru bir seçenek girin.");
                        }
                        break;
                }
            }
            else
            {
                // Geçersiz giriş durumu
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            }

            // Kullanıcıya devam etmek için bir tuşa basması hatırlatılır
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }

    // Döviz isimleri için bir dizi
    private static string[] DovizIsimleri =
    {
        "ABD Doları", "Euro", "İngiliz Sterlini", "Kanada Doları", "İsviçre Frangı",
        "Rus Rublesi", "Suudi Arabistan Riyali", "Japon Yeni", "Avustralya Doları",
        "Norveç Kronu", "Danimarka Kronu", "İsveç Kronu"
    };

    // Seçilen dövizin bilgilerini getiren metot
    public static Doviz DovizBilgisiniGetir(string dovizIsim)
    {
        // Hedef URL
        string url = "https://uzmanpara.milliyet.com.tr/doviz-kurlari/";

        // Web sayfasını indir
        string htmlIcerik;
        using (WebClient client = new WebClient())
        {
            htmlIcerik = client.DownloadString(url);
        }

        // HtmlAgilityPack belge oluştur
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(htmlIcerik);

        // Seçilen döviz bilgisini getir
        int satir = Array.IndexOf(DovizIsimleri, dovizIsim) + 1;
        Doviz doviz = new Doviz();
        doviz.Alis = DovizBilgisiniGetir(doc, satir, 3);
        doviz.Satis = DovizBilgisiniGetir(doc, satir, 4);

        return doviz;
    }

    // Belirtilen XPath ile döviz bilgisini getiren yardımcı metot
    private static string DovizBilgisiniGetir(HtmlDocument doc, int satir, int sutun)
    {
        // XPath oluştur
        string xpath = $"/html/body/div[13]/div[6]/div[2]/div[1]/table/tbody/tr[{satir}]/td[{sutun}]";

        // XPath ile belirli bir elementi seç
        var element = doc.DocumentNode.SelectSingleNode(xpath);

        // Eğer element bulunursa, içeriği al, aksi halde boş bir string döndür
        return element?.InnerText.Trim() ?? string.Empty;
    }
}

// Döviz sınıfı
public class Doviz
{
    public string Alis { get; set; }
    public string Satis { get; set; }
}
