using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Kullanıcının gireceği sırayı tutan değişken
            int sira = 0;

            while (true)
            {
                try
                {
                    // Kullanıcıdan sıra bilgisini al
                    Console.Write("Sıra : ");
                    sira = Convert.ToInt32(Console.ReadLine());

                    // Girilen sıra 1'den küçükse hata mesajı göster ve tekrar iste
                    if (sira < 1)
                        Console.WriteLine("Lütfen 1'den büyük bir sayı giriniz.");
                    else
                        break;

                }
                catch (Exception ex)
                {
                    // Hata durumunda temizle ve geçerli bir sayı girmeleri için kullanıcıyı uyar
                    Console.Clear();
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz => " + ex.Message);
                }
            }

            // Girilen sıra 1 veya 2 ise 1'i ekrana yazdır, değilse Fibonacci hesapla
            if (sira == 1 || sira == 2)
                Console.WriteLine("1");
            else
            {
                // Temizle ve Fibonacci hesaplamak için ilgili fonksiyonu çağır
                Console.Clear();
                Console.WriteLine(Fibonacci(sira));
            }

            // Programı sonlandırmadan önce kullanıcıdan bir tuş beklet
            Console.ReadKey();
        }

        // n. Fibonacci sayısını hesaplar
        static int Fibonacci(int sira)
        {
            // Fibonacci hesaplama için kullanılacak değişkenler
            int previous = 0, current = 1, next = 0;

            // Fibonacci dizisini hesapla
            for (int i = 0; i < sira - 1; i++)
            {
                next = previous + current;
                previous = current;
                current = next;
            }

            // n. Fibonacci sayısını döndür
            return current;
        }
    }
}
