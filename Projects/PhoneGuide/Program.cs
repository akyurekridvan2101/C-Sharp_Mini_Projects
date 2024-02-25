using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            // JSON dosya adı ve yolu
            string jsonDosyaYolu = "data.json";

            // JSON dosyasındaki veriyi oku veya oluştur
            TelefonRehberi telefonRehberi = JsonDosyasiniOkuVeyaOlustur(jsonDosyaYolu);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Telefon Rehberi Menüsü");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Kişi Ekle");
                Console.WriteLine("2. Kişi Güncelle");
                Console.WriteLine("3. Kişi Sil");
                Console.WriteLine("4. Rehberi Göster");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminizi yapın (1-5): ");

                if (int.TryParse(Console.ReadLine(), out int secim))
                {
                    switch (secim)
                    {
                        case 1:
                            KisiEkle(telefonRehberi);
                            break;
                        case 2:
                            KisiGuncelle(telefonRehberi);
                            break;
                        case 3:
                            KisiSil(telefonRehberi);
                            break;
                        case 4:
                            RehberiGoster(telefonRehberi);
                            break;
                        case 5:
                            // Çıkış
                            JsonDosyasinaYaz(telefonRehberi, jsonDosyaYolu);
                            Console.WriteLine("Programdan çıkılıyor.");
                            return;
                        default:
                            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                }

                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }

        // Kişi ekleme işlemini gerçekleştiren fonksiyon
        static void KisiEkle(TelefonRehberi telefonRehberi)
        {
            Console.Clear();
            Console.WriteLine("Kişi Ekleme Menüsü");
            Console.WriteLine("----------------------");

            Console.Write("Adı Girin: ");
            string ad = Console.ReadLine();

            Console.Write("Soyadı Girin: ");
            string soyad = Console.ReadLine();

            Console.Write("Telefon Numarası Girin: ");
            string telefon = Console.ReadLine();

            // Yeni kişi nesnesi oluşturup rehbere ekleniyor
            Kisi yeniKisi = new Kisi
            {
                Ad = ad,
                Soyad = soyad,
                Telefon = telefon
            };

            telefonRehberi.Kisiler.Add(yeniKisi);
            Console.WriteLine("Yeni kişi telefon rehberine eklendi.");
        }

        // Kişi güncelleme işlemini gerçekleştiren fonksiyon
        static void KisiGuncelle(TelefonRehberi telefonRehberi)
        {
            Console.Clear();
            Console.WriteLine("Kişi Güncelleme Menüsü");
            Console.WriteLine("----------------------");

            Console.Write("Güncellenecek Kişinin Adını Girin: ");
            string ad = Console.ReadLine();

            // Güncellenecek kişi bulunuyor
            Kisi guncellenecekKisi = telefonRehberi.Kisiler.FirstOrDefault(k => k.Ad == ad);

            if (guncellenecekKisi != null)
            {
                Console.Write("Yeni Soyadı Girin: ");
                guncellenecekKisi.Soyad = Console.ReadLine();

                Console.Write("Yeni Telefon Numarası Girin: ");
                guncellenecekKisi.Telefon = Console.ReadLine();

                Console.WriteLine("Kişi güncellendi.");
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı.");
            }
        }

        // Kişi silme işlemini gerçekleştiren fonksiyon
        static void KisiSil(TelefonRehberi telefonRehberi)
        {
            Console.Clear();
            Console.WriteLine("Kişi Silme Menüsü");
            Console.WriteLine("----------------------");

            Console.Write("Silinecek Kişinin Adını Girin: ");
            string ad = Console.ReadLine();

            // Silinecek kişi bulunuyor
            Kisi silinecekKisi = telefonRehberi.Kisiler.FirstOrDefault(k => k.Ad == ad);

            if (silinecekKisi != null)
            {
                // Kişi listeden siliniyor
                telefonRehberi.Kisiler.Remove(silinecekKisi);
                Console.WriteLine("Kişi silindi.");
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı.");
            }
        }

        // Rehberi gösterme işlemini gerçekleştiren fonksiyon
        static void RehberiGoster(TelefonRehberi telefonRehberi)
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("-----------------");

            // Rehberdeki her kişi sırasıyla ekrana yazdırılıyor
            foreach (var kisi in telefonRehberi.Kisiler)
            {
                Console.WriteLine($"Ad: {kisi.Ad}, Soyad: {kisi.Soyad}, Telefon: {kisi.Telefon}");
            }
        }

        // JSON dosyasını okuma veya oluşturma işlemini gerçekleştiren fonksiyon
        static TelefonRehberi JsonDosyasiniOkuVeyaOlustur(string jsonDosyaYolu)
        {
            if (File.Exists(jsonDosyaYolu))
            {
                // JSON dosyasındaki veriyi oku
                string jsonVerisi = File.ReadAllText(jsonDosyaYolu);
                return JsonSerializer.Deserialize<TelefonRehberi>(jsonVerisi);
            }
            else
            {
                // JSON dosyası yoksa yeni bir telefon rehberi oluştur
                return new TelefonRehberi { Kisiler = new List<Kisi>() };
            }
        }

        // Telefon rehberini JSON formatına çevirip dosyaya yazan fonksiyon
        static void JsonDosyasinaYaz(TelefonRehberi telefonRehberi, string jsonDosyaYolu)
        {
            // Telefon rehberini JSON formatına çevir ve dosyaya yaz
            string jsonVerisi = JsonSerializer.Serialize(telefonRehberi);
            File.WriteAllText(jsonDosyaYolu, jsonVerisi);
        }
    }

    // Kişi sınıfı
    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
    }

    // TelefonRehberi sınıfı
    class TelefonRehberi
    {
        public List<Kisi> Kisiler { get; set; }
    }
}
