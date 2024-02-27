using System;

class Program
{
    static void Main()
    {
        uint sayi;

        // Kullanıcıdan geçerli bir pozitif tamsayı girişi alana kadar döngüyü sürdür.
        while (true)
        {
            Console.Write("Bir sayı giriniz (Pozitif tamsayı olmalıdır.): ");
            
            // Kullanıcının girişini kontrol et ve geçerli bir tamsayı ise döngüden çık.
            if (uint.TryParse(Console.ReadLine(), out sayi) && sayi != 0)
            {
                break;
            }
            else
            {
                // Geçersiz giriş durumunda kullanıcıya uyarı mesajı göster.
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lütfen pozitif bir tamsayı giriniz.");
                Console.ResetColor();
            }
        }

        // Mükemmel sayı kontrolü yap ve sonucu ekrana yazdır.
        if (IsPerfectNumber(sayi))
        {
            Console.WriteLine($"{sayi} mükemmel bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} mükemmel bir sayı değildir.");
        }
    }

    // Bir sayının mükemmel sayı olup olmadığını kontrol eden fonksiyon.
    static bool IsPerfectNumber(uint sayi)
    {
        int toplam = 0;

        // Sayının yarısına kadar olan bölenleri kontrol et.
        // toplam değeri sayıyı geçerse döngüyü sonlandır.
        for (int i = 1; i <= sayi / 2 && toplam <= sayi; i++)
        {
            // i sayıya bölünen bir bölen ise toplama ekle.
            if (sayi % i == 0)
            {
                toplam += i;
            }
        }

        // Toplam, sayıya eşitse sayı mükemmel bir sayıdır.
        return toplam == sayi;
    }
}
