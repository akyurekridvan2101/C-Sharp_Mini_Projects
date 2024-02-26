using System;

public class Program
{
    // Ana program başlangıcı
    static void Main()
    {
        // Kullanıcıdan bir kelime iste
        Console.Write("Bir kelime girin: ");
        string kullaniciKelime = Console.ReadLine();

        // IsPalindrom fonksiyonunu çağırarak sonucu ekrana yazdır
        Console.WriteLine($"Girilen kelime palindrom mu? {IsPalindrom(kullaniciKelime)}");
    }

    // Palindrom kontrolü yapan fonksiyon
    static bool IsPalindrom(string kelime)
    {
        // Eğer kelimenin uzunluğu 1 ise, palindromdur
        if (kelime.Length == 1)
            return true;

        // Kelimenin yarısına kadar olan kısmı kontrol eder
        for (int i = 0; i < kelime.Length / 2; i++)
        {
            // Karakterlerin karşılıklı olarak eşit olup olmadığını kontrol eder
            if (kelime[i] != kelime[kelime.Length - i - 1])
                return false;
        }

        // Tüm kontroller geçildiyse kelime palindromdur
        return true;
    }
}

