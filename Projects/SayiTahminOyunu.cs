using System;

class Program
{
    // Random nesnesi sadece bir kez oluşturulmalıdır, her seferinde aynı seed ile başlamamalıdır.
    static Random random = new Random();

    // Kullanıcının kaç tahminde doğru sayıyı bulduğunu takip eden değişken.
    static int tahminSayisi = 0;

    // Oyunun başladığı ana metod.
    static void Main()
    {
        // 1 ile 100 arasında rastgele bir sayı üret
        int uretilenSayi = random.Next(1, 100);

        // Kullanıcının sayıyı tahmin etmeye çalıştığı döngü
        while (!SayiTahmin(uretilenSayi)) ;
    }

    // Kullanıcının sayıyı tahmin ettiği metod.
    static bool SayiTahmin(int uretilenSayi)
    {
        // Kullanıcının kaçıncı tahminde olduğunu artır.
        tahminSayisi++;

        // Kullanıcının gireceği tahmin değeri
        int kullaniciTahmini;

        // Kullanıcının geçerli bir tamsayı girene kadar döngü
        while (true)
        {
            try
            {
                Console.Write("Tahmininiz: ");
                kullaniciTahmini = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                // Format hatası durumunda kullanıcıya bilgi ver
                Console.Write("\nLütfen sadece tamsayı giriniz...\n");
            }
            catch (Exception ex)
            {
                // Format hatası dışında beklenmeyen bir hata durumunda kullanıcıya sistemin yolladığı hata mesajını verir
                Console.Write("\nBir hata oluştu: " + ex.Message + "\n");
            }
        }

        // Kullanıcının tahminine göre geri bildirim ver
        if (kullaniciTahmini < uretilenSayi)
        {
            Console.WriteLine("Sayıyı arttırın...");
            return false;
        }
        else if (kullaniciTahmini > uretilenSayi)
        {
            Console.WriteLine("Sayıyı azaltın...");
            return false;
        }
        else
        {
            // Kullanıcının sayıyı doğru tahmin ettiği durum
            Console.WriteLine($"Bravo! Sayıyı {tahminSayisi} tahminde buldunuz...");
            return true;
        }
    }
}
