using System;

class AsalSayilar
{
    static void Main()
    {

        Console.Write("Bir üst sınır girin : ");
        int ustSinir;

        // Kullanıcıdan geçerli bir sayı alana kadar döngü devam eder
        while (true)
        {

            try
            {
                ustSinir = Convert.ToInt32(Console.ReadLine());
                break; // Hata olmadan geçerli bir sayı alındığında döngüden çık
            }
            catch (FormatException)
            {
                Console.Write("Hata: Lütfen sadece sayı girin : ");
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Hata: Bir hata oluştu => " + ex2.Message);
                return; // Programı sonlandır
            }
        }

        Console.WriteLine($"1 ile {ustSinir} arasındaki asal sayılar:");

        // Asal sayıları bulan döngü
        for (int i = 2; i <= ustSinir; i++)
        {
            if (AsalMi(i))
            {
                Console.WriteLine($"{i} ");
            }
        }

        Console.ReadLine();
    }

    // Verilen sayının asal olup olmadığını kontrol eden fonksiyon
    static bool AsalMi(int sayi)
    {
        if (sayi < 2)
        {
            return false;
        }

        int kok = (int)Math.Sqrt(sayi);

        // Kök kadar olan sayılara kadar bölenleri kontrol eden döngü 
        for (int i = 2; i <= kok; i++)
        {
            if (sayi % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
