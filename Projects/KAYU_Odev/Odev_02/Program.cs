using System;
using System.Threading;

namespace ZarOyunu
{
    // Zar sınıfı, zar oyununda kullanılan zar nesnesini temsil eder.
    class Zar
    {
        int[] zarYuzleri; // Zarın yüzlerine yazılan sayıları tutacak dizi.
        Random random; // Rastgele sayı üretmek için random nesnesi oluşturdum. Sınıf elemanı olarak oluşturmamın sebebi her seferinde newlememek için.

        // Zar sınıfının constructor'ı, zar yüzlerini başlatır.
        public Zar()
        {
            random = new Random();
            zarYuzleri = new int[6];
            ZarYuzlerineSayiYaz();
        }

        // Zarın yüzlerine farklı sayılar atayan metot.
        public void ZarYuzlerineSayiYaz()
        {
            for (int i = 0; i < 6; i++)
            {
                int randomSayi;
                while (true)
                {
                    randomSayi = this.random.Next(1, 26); // 1-25 arası rastgele sayı üretir.

                    bool zardaVarMi = ZardaVarMi(randomSayi, i);

                    if (!zardaVarMi)
                    {
                        this.zarYuzleri[i] = randomSayi;
                        break;
                    }
                }
            }
        }

        // Verilen sayının zar yüzlerinde daha önce kullanılıp kullanılmadığını kontrol eden metot.
        private bool ZardaVarMi(int randomSayi, int currentIndex)
        {
            for (int j = 0; j < currentIndex; j++)
            {
                if (this.zarYuzleri[j] == randomSayi)
                    return true;
            }
            return false;
        }

        // Zar atma işlemini gerçekleştiren metot.
        public int ZarAt()
        {
            return zarYuzleri[random.Next(6)];
        }
    }

    // Oyuncu sınıfı, zar oyununda bir oyuncuyu temsil eder.
    class Oyuncu
    {
        public readonly string Ad; // Oyuncu adını constructor içinde tanımladıktan sonra değiştirilemez yapmak için readonly anahtar kelimesi ile tanımladım.
        public int Puan { get; set; } = 0; // Oyuncunun toplam puanını tutan özellik.

        // Oyuncu sınıfının constructor'ı, oyuncu adını başlatır.
        public Oyuncu(string oyuncuAdi)
        {
            this.Ad = oyuncuAdi;
        }

        // Oyuncunun puanını zar atarak artıran metot.
        public void PuanEkle(Zar zarNesnesi)
        {
            int gelenSayi = zarNesnesi.ZarAt();
            Puan += gelenSayi;
            Console.WriteLine($"{Ad} isimli oyuncu {gelenSayi} sayısını attı. Toplam Puan: {Puan}");
            Thread.Sleep(1000); // Daha okunaklı olmasını sağlamak için saniye beklemesini sağladım.
        }
    }

    class Program
    {
        // Zar oyununu başlatan ve sonuçları gösteren ana program.
        static void Main(string[] args)
        {
            Zar zarimiz = new Zar(); // Her iki oyuncu için de tek zar nesnesi olmalı ki zar yüzlerinde yazan sayılar aynı olsun ve adaletsizlik olmasın.

            Console.Write("Oyuncu 1 Adı: ");
            string oyuncu1Ad = Console.ReadLine();

            Console.Write("Oyuncu 2 Adı: ");
            string oyuncu2Ad = Console.ReadLine();

            Oyuncu oyuncu1 = new Oyuncu(oyuncu1Ad) { Puan = 0 };
            Oyuncu oyuncu2 = new Oyuncu(oyuncu2Ad) { Puan = 0 };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("********* ANLIK PUANLAR *********");
                Console.WriteLine($"{oyuncu1.Ad}: {oyuncu1.Puan}");
                Console.WriteLine($"{oyuncu2.Ad}: {oyuncu2.Puan}\n");

                Console.WriteLine($"{oyuncu1Ad} Zar Atmak için herhangi bir tuşa bas...");
                Console.Read();
                oyuncu1.PuanEkle(zarimiz);

                Console.WriteLine($"\n{oyuncu2Ad} Zar Atmak için herhangi bir tuşa bas...\n");
                Console.ReadKey();
                oyuncu2.PuanEkle(zarimiz);

                if (oyuncu1.Puan >= 50 || oyuncu2.Puan >= 50)
                    break;
            }

            SonuclariGoster(oyuncu1, oyuncu2);
            Console.ReadKey();
        }

        // Oyuncuların sonuçlarını ekrana yazdıran metot.
        public static void SonuclariGoster(Oyuncu oyuncu1, Oyuncu oyuncu2)
        {
            Console.Clear();

            Console.WriteLine($@"{oyuncu1.Ad} isimli oyuncunun aldığı puan = {oyuncu1.Puan}
    {oyuncu2.Ad} isimli oyuncunun aldığı puan = {oyuncu2.Puan}");

            Console.ForegroundColor = ConsoleColor.Green;
            if (oyuncu1.Puan > oyuncu2.Puan)
                Console.WriteLine($"{oyuncu1.Ad} oyunu kazandı!");
            else if (oyuncu1.Puan == oyuncu2.Puan)
                Console.WriteLine("Berabere kalındı...");
            else
                Console.WriteLine($"{oyuncu2.Ad} oyunu kazandı!");

            Console.ResetColor();
        }
    }

}
