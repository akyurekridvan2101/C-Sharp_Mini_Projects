using System;

class Program
{
    // Kelimelerin bulunduğu dizi
    static readonly string[] kelimeler = {
        "bilgisayar",
        "mühendislik",
        "yazılım",
        "donanım",
        "algoritma",
        "veritabanı",
        "elektronik",
        "programlama",
        "android",
        "robotik"
    };

    // Hata sayısını tutan değişken
    static int hataSayisi = 0;

    // Türkçe harfleri içeren dizi
    static readonly char[] turkcedekiHarfler =
    {
        'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k',
        'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z'
    };

    static void Main()
    {
        // Oyun kurallarını yazdıran fonksiyon
        YazdirAdamAsmacaKurallari();

        // Rastgele bir kelime seçme
        string kelime = kelimeler[new Random().Next(0, kelimeler.Length)];
        string[] kelimeTahmin = new string[kelime.Length];

        // Kelime tahmin dizisini '_' ile başlatma
        for (int i = 0; i < kelime.Length; i++)
        {
            kelimeTahmin[i] = "_";
        }

        // Oyun devam ettikçe dönen döngü
        while (hataSayisi != 6)
        {
            Console.Clear();
            // Adam asmaca grafiğini çizme
            AdamAsmacaCiz();
            Console.WriteLine();

            // Kelime tahmin durumunu ekrana yazdırma
            for (int i = 0; i < kelimeTahmin.Length; i++)
            {
                Console.Write($" {kelimeTahmin[i]} ");
            }

            int secim;

            // Kullanıcıdan doğru bir seçim alana kadar dönen döngü
            while (true)
            {
                try
                {
                    Console.Write("Kelime tahmin etmek için => 1'e\n" +
                        "Cevabı tahmin etmek için => 2'ye (Yanlış cevaplamanz durumunda oyunu kaybedersiniz)\n\n" +
                        "Basıp enter tuşuna basınız : ");

                    // Kullanıcının seçimini alma
                    secim = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nLütfen sadece 1 veya 2 girin\n");
                    Console.ResetColor();
                }
            }

            // Kullanıcının seçimine göre işlem yapma
            if (secim == 1)
            {
                char harf;

                // Kullanıcıdan geçerli bir harf alana kadar dönen döngü
                while (true)
                {
                    try
                    {
                        Console.Write("Bir harf giriniz : ");
                        harf = Convert.ToChar(Console.ReadLine().ToLower());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Lütfen sadece bir harf girin");
                        continue;
                    }

                    // Girilen harfin Türkçe harf olup olmadığını kontrol etme
                    bool turkceHarfMi = false;
                    for (int i = 0; i < turkcedekiHarfler.Length; i++)
                    {
                        if (harf == turkcedekiHarfler[i])
                        {
                            turkceHarfMi = true;
                            break;
                        }
                    }

                    if (!turkceHarfMi)
                    {
                        Console.WriteLine("Lütfen sadece Türkçe karakterler girin");
                        continue;
                    }
                    else
                        break;
                }

                // Harf tahminini kontrol etme ve gerekirse hata sayısını artırma
                if (!HarfGuncelle(kelime, ref kelimeTahmin, harf))
                    hataSayisi++;
            }

            else if (secim == 2)
            {
                // Kullanıcının kelime tahminini alma
                Console.Write("Kelimeyi tahmin ediniz : ");
                string cevap = Console.ReadLine().ToLower();

                // Kullanıcının kelime tahminini kontrol etme
                if (cevap == kelime)
                {
                    Console.Clear();
                    AdamAsmacaCiz();
                    Console.WriteLine("Tebrikler, oyunu kazandınız");
                    break;
                }
                else
                {
                    Console.Clear();
                    hataSayisi = 6;
                    AdamAsmacaCiz();
                    Console.WriteLine("Oyunu kaybettiniz");
                    break;
                }
            }

            // Oyunun durumuna göre işlem yapma
            if (hataSayisi == 6)
            {
                Console.Clear();
                AdamAsmacaCiz();
                Console.WriteLine("Oyunu kaybettiniz");
                break;
            }
            else if (string.Join("", kelimeTahmin) == kelime)
            {
                Console.Clear();
                AdamAsmacaCiz();
                Console.WriteLine("Tebrikler, oyunu kazandınız");
                break;
            }
        }
    }

    // Oyun kurallarını ekrana yazdıran fonksiyon
    static void YazdirAdamAsmacaKurallari()
    {
        Console.WriteLine(
        @"
=======================================
   ADAM ASMACA OYUNU KURALLARI   
=======================================
1. Bilgisayar bir kelime seçer.
2. Oyuncu, seçilen kelimenin harf sayısını tahmin eder.
3. Oyuncu her seferinde bir harf tahmin eder.
4. Doğru tahmin edilen harfler, kelimenin ilgili yerlerine yerleştirilir.
5. Yanlış tahmin edilen her harf için bir hata sayısı eklenir.
6. Oyuncu, belirli bir hata sayısına ulaşırsa oyun kaybedilir.
7. Oyuncu, tüm harfleri doğru tahmin ederse oyun kazanılır.

=======================================
  OYUNU BAŞLATMAK İÇİN BİR TUŞA BASIN   
======================================="
        );

        Console.ReadKey();
    }

    // Adam asmaca grafiğini çizen fonksiyon
    static void AdamAsmacaCiz()
    {
        string[] pics = {
            @"
           +---+
           |   |
               |
               |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
               |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
           |   |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
          /|   |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
          /|\  |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
          /|\  |
          /    |
               |
        =========",
            @"
           +---+
           |   |
           O   |
          /|\  |
          / \  |
               |
        ========="
        };

        Console.WriteLine(pics[hataSayisi]);
    }

    // Harfi güncelleyen fonksiyon
    static bool HarfGuncelle(string cevap, ref string[] kelimeTahmin, char harf)
    {
        bool harfVarMi = false;
        for (int i = 0; i < cevap.Length; i++)
        {
            if (cevap[i] == harf)
            {
                harfVarMi = true;
                kelimeTahmin[i] = $"{harf}";
            }
        }

        return harfVarMi;
    }
}
