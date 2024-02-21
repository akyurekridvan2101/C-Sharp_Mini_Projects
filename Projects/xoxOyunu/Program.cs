using System;

class Program
{
    // Oyun tahtasını temsil eden dizi
    static string[] xoxTahtasi = { "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   " };
    static int kazananOyuncu = 0; // 0 : Kazanan yok, 1: Oyuncu 1, 2: Oyuncu 2

    static void Main()
    {
        string oyuncu_1, oyuncu_2;

        Console.Write("Oyuncu 1 ismi giriniz: ");
        oyuncu_1 = Console.ReadLine() ?? "oyuncu_1";
        Console.Write("Oyuncu 2 ismi giriniz: ");
        oyuncu_2 = Console.ReadLine() ?? "oyuncu_2";

        Console.Clear();

        Console.WriteLine("Oyun Tahtası");
        TahtaGoster();

        for (int i = 1; i <= 9; i++)
        {
            // Oyuncu sırasına göre X veya O ekleyerek tahtayı güncelle
            OyunTahtasiGuncelle((i % 2 == 0) ? 2 : 1 , 0, 0);
            TahtaGoster();

            // Kazanan kontrolü
            if (KazananKontrol())
            {
                string kazananYazdir = (i % 2 != 0) ? oyuncu_1 : oyuncu_2 + " KAZANDI...";

                Console.WriteLine($"\n{kazananYazdir}");
                break;
            }
        }

        if (kazananOyuncu == 0)
            Console.WriteLine("\nBERABERE...");
    }

    // Oyun tahtasını ekrana yazdıran metod
    static void TahtaGoster()
    {
        Console.ForegroundColor = ConsoleColor.Black;

        for (int i = 0; i < 9; i++)
        {
            

            if (i % 3 == 0)
            {
                Console.ResetColor();
                Console.WriteLine();
            }

                

            // Alternatif renkli arka planlar
            Console.BackgroundColor = (i % 2 == 0) ? ConsoleColor.Red : ConsoleColor.Blue;
            Console.Write($"{xoxTahtasi[i]}");
        }

        Console.ResetColor();
        Console.WriteLine();
    }

    // Oyuncunun hamlesini alıp tahtayı güncelleyen metod
    static void OyunTahtasiGuncelle(int oyuncuKarakteri, int satir, int sutun)
    {
        while (true)
        {
            try
            {
                while (true)
                {
                    Console.Write("Satırı giriniz(1 ile 3 arasında olmalıdır) : ");
                    satir = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nSütunu giriniz(1 ile 3 arasında olmalıdır...) : ");
                    sutun = Convert.ToInt32(Console.ReadLine());

                    // Geçerli hamle kontrolü
                    if (satir < 1 || satir > 3 || sutun < 1 || sutun > 3)
                    {
                        Console.Clear();
                        TahtaGoster();
                        Console.WriteLine("Lütfen 1 ile 3 arasında bir değer giriniz...");
                        continue;
                    }
                    else if (xoxTahtasi[(satir - 1) * 3 + (sutun - 1)] != "   ")
                    {
                        Console.Clear();
                        TahtaGoster();
                        Console.WriteLine("Bu alan dolu...");
                        continue;
                    }
                    else
                        break;
                }

                break;
            }
            catch (Exception)
            {
                Console.Clear();
                TahtaGoster();
                Console.WriteLine("Lütfen geçerli bir değer giriniz...");
            }
        }

        // Oyuncu karakterine göre X veya O ekleyerek tahtayı güncelle
        xoxTahtasi[(satir - 1) * 3 + (sutun - 1)] = oyuncuKarakteri == 1 ? " X " : " O ";
    }

    // Kazanan kontrolünü yapan metod
    static bool KazananKontrol()
    {
        // Satır, sütun ve çapraz kontrolleri
        if (xoxTahtasi[0] != "   " && xoxTahtasi[0] == xoxTahtasi[1] && xoxTahtasi[1] == xoxTahtasi[2])
            return true;
        else if (xoxTahtasi[3] != "   " && xoxTahtasi[3] == xoxTahtasi[4] && xoxTahtasi[4] == xoxTahtasi[5])
            return true;
        else if (xoxTahtasi[6] != "   " && xoxTahtasi[6] == xoxTahtasi[7] && xoxTahtasi[7] == xoxTahtasi[8])
            return true;
        else if (xoxTahtasi[0] != "   " && xoxTahtasi[0] == xoxTahtasi[3] && xoxTahtasi[3] == xoxTahtasi[6])
            return true;
        else if (xoxTahtasi[1] != "   " && xoxTahtasi[1] == xoxTahtasi[4] && xoxTahtasi[4] == xoxTahtasi[7])
            return true;
        else if (xoxTahtasi[2] != "   " && xoxTahtasi[2] == xoxTahtasi[5] && xoxTahtasi[5] == xoxTahtasi[8])
            return true;
        else if (xoxTahtasi[0] != "   " && xoxTahtasi[0] == xoxTahtasi[4] && xoxTahtasi[4] == xoxTahtasi[8])
            return true;
        else if (xoxTahtasi[2] != "   " && xoxTahtasi[2] == xoxTahtasi[4] && xoxTahtasi[4] == xoxTahtasi[6])
            return true;
        else
            return false;
    }
}
