using System;

namespace ConsoleApp_Core
{
    class Program
    {
        // Kullanıcı bilgilerini saklamak için static değişkenler tanımladım class elemanları oldukları için derleyici tarafından default değerleri atanır.
        static string ad;
        static string soyad;
        static string numara;
        static string cinsiyet;
        static DateTime dogumTarihi;

        static void Main()
        {
            Console.Title = "Kullanıcı Bilgi Sistemi";//Konsolun üst kısmında başlık olarak gösterilecek metni belirledim aslında gereksiz ama güzel duruyor.

            KullaniciBilgileriniAl();//Kullanıcı bilgilerini almak için fonksiyonu çağırdım.
            int haftaKacGun = (cinsiyet == "erkek") ? 8 : 5;
            int ayKacHafta = OnSekizdenGunAldiMi(dogumTarihi) ? 5 : 6;
            int kacGunSonra = KacGunSonraIsVar();

            // Yazdır fonksiyonunu çağırarak bilgileri ekrana yazdırdım.
            Yazdir(haftaKacGun, ayKacHafta, kacGunSonra);
            Console.ReadKey();
        }

        //TODO : Kullanıcı bilgilerini al
        static void KullaniciBilgileriniAl()
        {
            Console.WriteLine("=== Kullanıcı Bilgi Girişi ===");

            // Kullanıcıdan ad, soyad, numara, cinsiyet ve doğum tarihi bilgilerini al
            Console.Write("Adınız: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("Numaranız: ");
            numara = Console.ReadLine();

            // Cinsiyet bilgisini alırken geçerli bir değer girene kadar döngü kullandım.
            while (true)
            {
                Console.Write("Cinsiyetiniz (erkek/kadın): ");
                cinsiyet = Console.ReadLine().ToLower();

                if (cinsiyet == "erkek" || cinsiyet == "kadın")
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cinsiyetinizi erkek/kadın olarak girmelisiniz...");
                    Console.ResetColor();
                }
            }

            // Doğum tarihi alırken hatalı girişleri kontrol et ve geçerli bir tarih alana kadar döngü kullandım
            while (true)
            {
                try
                {
                    Console.Write("Doğum tarihinizi giriniz (YYYY-AA-GG): ");
                    dogumTarihi = Convert.ToDateTime(Console.ReadLine());

                    // Doğum tarihi, bugünün tarihinden küçük veya eşit olmalıdır.
                    if (dogumTarihi <= DateTime.Now)
                        break;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geçersiz doğum tarihi girdiniz.Doğum tarihiniz şu andaki tarihten büyük olamaz...");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Doğum tarihini doğru bir şekilde yazınız (YYYY-AA-GG)...");
                    Console.ResetColor();
                }
                catch (Exception ex)//Beklenmeyen hata durumunda kullanıcıya hata mesajı gösterecek
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Beklenmeyen hata oluştu. Hata mesajı => " + ex.Message);
                    Console.ResetColor();
                }
            }
        }

        //TODO : İş günü hesaplaması
        static int KacGunSonraIsVar()
        {
            Console.WriteLine("=== İş Bilgisi ===");

            // İş günü hesaplaması için kaç gün sonra sorusunu kullanıcının int dışında bir değer girmesi durumunda hata mesajı gösterip tekrar sormak için döngü kullandım.
            while (true)
            {
                try
                {
                    Console.Write("Kaç gün sonra işiniz var: ");
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen sayısal bir değer giriniz...");
                    Console.ResetColor();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Beklenmeyen hata oluştu. Hata mesajı => " + ex.Message);
                    Console.ResetColor();
                    continue;
                }
            }
        }

        //TODO : 18 yaşından gün alıp almadığını kontrol etme
        // 18 yaşından gün almış mı kontrolü
        static bool OnSekizdenGunAldiMi(DateTime dogumTarihi)
        {
            DateTime simdikiTarih = DateTime.Now;

            TimeSpan fark = simdikiTarih - dogumTarihi;

            return fark.TotalDays >= (18 * 365 - 30); // 18 * 365 - 30 derken 18 yaşından gün almış mı kontrolü yapıyorum. 18 yaşından gün almışsa true döner.
        }

        //TODO : Bilgileri ekrana yazdırma fonksiyonu
        // Bilgileri ekrana yazdırma fonksiyonu
        static void Yazdir(int haftaKacGun, int ayKacHafta, int kacGunSonra)
        {
            Console.Clear();
            int eklenecekAy = kacGunSonra / (haftaKacGun * ayKacHafta);
            int eklenecekHafta = (kacGunSonra - (eklenecekAy * haftaKacGun * ayKacHafta)) / haftaKacGun;
            int eklenecekGun = kacGunSonra - (eklenecekAy * haftaKacGun * ayKacHafta) - (eklenecekHafta * haftaKacGun);

            // İş gününü hesapla ve ekrana yazdır
            DateTime isGunu = DateTime.Now.AddMonths(eklenecekAy);
            isGunu = isGunu.AddDays(eklenecekHafta * 7);//eklenecek hafta sayısını gün cinsinden hesapladım.DateTime sınıfında AddWeeks diye bir fonksiyon olmadığı için bu şekilde yaptım.
            isGunu = isGunu.AddDays(eklenecekGun);
            string cinsiyetMetni = (cinsiyet == "erkek") ? "bey" : "hanım";

            Console.WriteLine($@"
=== Kullanıcı Bilgileri ===
Adı: {ad}
Soyadı: {soyad}
Numarası: {numara}
Cinsiyeti: {cinsiyet}
Doğum Tarihi: {dogumTarihi:yyyy-MM-dd}

=== İş Bilgisi ===
Sayın {ad} {soyad} {cinsiyetMetni}, {DateTime.Now.Year - dogumTarihi.Year} yaşındasınız ve {isGunu:yyyy-MM-dd} tarihinde işiniz var");

        }


    }
}
