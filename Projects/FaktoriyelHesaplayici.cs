using System;

class FaktoriyelHesaplayici
{
    static void Main()
    {
        // Kullanıcıdan faktöriyeli hesaplanacak sayıyı girmesini iste
        Console.Write("Faktöriyeli hesaplanacak sayıyı giriniz: ");
        int sayi;

        // Kullanıcıdan geçerli bir sayı alana kadar döngü devam eder
        while (true)
        {
            try
            {
                // Kullanıcının girdiği metni bir tamsayıya çevir
                sayi = Convert.ToInt32(Console.ReadLine());

                // Hata olmadan geçerli bir sayı alındığında döngüden çık
                break;
            }
            catch (FormatException)
            {
                // Kullanıcı metin girdiğinde bir hata mesajı ver ve tekrar sayı iste
                Console.Write("Hata: Lütfen sadece sayı girin: ");
            }
            catch (Exception ex)
            {
                // Diğer olası hatalar için bir genel hata mesajı ver ve programı sonlandır
                Console.WriteLine("Hata: Bir hata oluştu => " + ex.Message);
                return;
            }
        }

        // Girilen sayının negatif olup olmadığını kontrol et
        if (sayi < 0)
            Console.WriteLine("Negatif sayılar için faktöriyel tanımlı değildir.");
        else if (sayi == 0)
            Console.WriteLine("0! = 1");
        else
            // Faktöriyel hesaplamak için FaktoriyelHesapla fonksiyonunu çağır ve sonucu ekrana yazdır
            Console.WriteLine($"{sayi}! = {FaktoriyelHesapla(sayi)}");
    }

    // Faktöriyel hesaplamak için rekürsif bir fonksiyon
    static int FaktoriyelHesapla(int sayi)
    {
        // Temel durum: 0'ın faktöriyeli 1'dir
        if (sayi == 0)
            return 1;
        else
            // Rekürsif durum: sayi * (sayi-1)!
            return sayi * FaktoriyelHesapla(sayi - 1);
    }
}
