using System;

class Program
{
    static void Main(string[] args)
    {
        // Küçükten büyüğe sayıları içeren 100 elemanlı bir dizi.
        int[] dizi = {
            1, 10, 11, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70,
            75, 80, 85, 90, 95, 100, 105, 110, 115, 120, 125, 130, 135, 140, 145, 150,
            155, 160, 165, 170, 175, 180, 185, 190, 195, 200, 205, 210, 215, 220, 225,
            230, 235, 240, 245, 250, 255, 260, 265, 270, 275, 280, 285, 290, 295, 300,
            305, 310, 315, 320, 325, 330, 335, 340, 345, 350, 355, 360, 365, 370, 375,
            380, 385, 390, 395, 400, 405, 410, 415, 420, 425, 430, 435, 440, 445, 450,
            455, 460, 465, 470, 475, 480, 485, 490, 495
        };

        int aranacakSayi;

        while (true)
        {
            try
            {
                // Kullanıcıdan bir sayı girişi istenir.
                Console.Write("Bir sayı giriniz: ");
                aranacakSayi = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                // Hata durumunda kullanıcıya sadece tamsayı girmesi gerektiği hatırlatılır.
                Console.WriteLine("Lütfen sadece tamsayı giriniz...");
            }
        }

        // Girilen sayının dizideki index'ini bulma işlemi yapılır.
        int indexi = IndexBulucu(dizi, aranacakSayi);

        // Sonuçlar ekrana yazdırılır.
        if (indexi != -1)
            Console.WriteLine($"{aranacakSayi} sayısının bulunduğu index numarası: " + indexi);
        else
            Console.WriteLine("Aranan sayı dizide yok...");

        // Kullanıcının bir tuşa basmasını bekler.
        Console.ReadKey();
    }

    // Binary search algoritması ile dizideki bir sayının index'ini bulan fonksiyon.
    static int IndexBulucu(int[] dizi, int aranacakSayi)
    {
        int baslangicIndex = 0, bitisIndex = dizi.Length - 1;

        while (baslangicIndex <= bitisIndex)
        {
            int ortaIndex = (baslangicIndex + bitisIndex) / 2;

            if (aranacakSayi == dizi[ortaIndex])
                return ortaIndex;
            else if (aranacakSayi < dizi[ortaIndex])
                bitisIndex = ortaIndex - 1;
            else // aranacakSayi > dizi[ortaIndex]
                baslangicIndex = ortaIndex + 1;
        }

        // Aranacak sayı bulunamazsa -1 döndürülür.
        return -1;
    }
}