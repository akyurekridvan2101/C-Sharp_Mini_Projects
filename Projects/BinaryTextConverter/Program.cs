using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan metin girişi alınır
        Console.Write("Metin girin: ");
        string metin = Console.ReadLine() ?? "null değer";

        // Metin, PrintBytes metoduna gönderilir
        PrintBytes(metin);
    }

    // Girilen metni binary formatta ekrana yazdıran metod
    static void PrintBytes(string metin)
    {
        if (String.IsNullOrEmpty(metin))
        {
            // Eğer metin boş veya null ise hata mesajı verilir
            Console.WriteLine("Metin girilmediği için çevrilemedi...");
        }
        else
        {
            foreach (char karakter in metin.ToCharArray())
            {
                // Karakteri binary formata çevirip ekrana yazdıran metod çağrılır
                char[] bits = CharToBits(karakter).ToCharArray();
                Array.Reverse(bits);
                Console.WriteLine(bits);
            }
            Console.WriteLine(); // Bir satır atla
        }
    }

    // Karakteri binary formata çeviren metod
    static string CharToBits(char siradakiKarakter)
    {
        int asciiDegeri = siradakiKarakter;

        // Karakterin binary temsili için 16-bitlik bir dizi oluşturulur
        char[] bits = "0000000000000000".ToCharArray();

        if (asciiDegeri == 0)
            return "0000000000000000";

        int max = 0, sayiKontrol = 0;

        // Karakterin binary temsilini oluşturan döngü
        for (int i = 0; i <= 15; i++)
        {
            if (Math.Pow(2, i) > asciiDegeri)
            {
                max = i - 1;
                bits[max] = '1';
                break;
            }
        }

        sayiKontrol += (int)Math.Pow(2, max);

        // Karakterin binary temsilini devam ettiren döngü
        for (int i = max - 1; i >= 0; i--)
        {
            if (sayiKontrol + (int)Math.Pow(2, i) <= asciiDegeri)
            {
                bits[i] = '1';
                sayiKontrol += (int)Math.Pow(2, i);
            }
        }

        return new string(bits);
    }
}
