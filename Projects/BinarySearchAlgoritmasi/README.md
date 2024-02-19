# Binary Search Example

Bu proje, küçükten büyüğe sıralanmış bir dizide binary search algoritması kullanarak bir sayının index'ini bulmayı sağlayan bir C# programını içerir.

## Binary Search: Algoritmanın Avantajları

Binary search, sıralı bir dizide belirli bir öğeyi bulmak için kullanılan etkili bir algoritmadır. İşte binary search'in kullanılmasının temel avantajları:

## 1. Hızlı Performans

Binary search, her adımda arama aralığını yarıya indirerek çalıştığı için logaritmik bir zaman karmaşıklığına sahiptir (O(log n)). Bu, büyük veri setlerinde hızlı performans sağlar.

## 2. Etkin Bellek Kullanımı

Sıralı bir dizide çalışan binary search, arama aralığını sürekli olarak yarıya indirir. Bu nedenle, çok az bellek kullanır ve bellek verimliliği sağlar.

## 3. Düşük Karşılaştırma Sayısı

Her adımda arama aralığını yarıya böldüğü için binary search, diğer sıralama algoritmalarına göre daha az karşılaştırma yapar. Bu, algoritmanın daha verimli olmasını sağlar.

Binary search, özellikle sıralı veri setlerinde belirli bir öğenin hızlı bir şekilde bulunması gereken durumlarda tercih edilir. Logaritmik zaman karmaşıklığı, büyük veri setlerinde bile hızlı performans sağlayarak binary search'i yaygın olarak kullanılır hale getirir.


## Nasıl Çalışır?

1. **Dizi Oluşturma:** Program, küçükten büyüğe sıralanmış bir diziyi içerir. Örneğin:

    ```csharp
    int[] dizi = { 1, 10, 11, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, ... };
    ```

2. **Kullanıcı Girişi:** Kullanıcıya bir tamsayı girmesi istenir. Kullanıcı doğru formatta bir sayı girene kadar hata kontrolü yapılır.

    ```csharp
    Console.Write("Bir sayı giriniz: ");
    int aranacakSayi = Convert.ToInt32(Console.ReadLine());
    ```

3. **Binary Search İşlemi:** `IndexBulucu` fonksiyonu, binary search algoritması kullanılarak girilen sayının dizideki index'ini bulur.

    ```csharp
    int indexi = IndexBulucu(dizi, aranacakSayi);
    ```

4. **Sonuç Gösterimi:** Elde edilen index, eğer -1 değilse, ekrana yazdırılır. Aksi takdirde, "Aranan sayı dizide yok..." mesajı görüntülenir.

    ```csharp
    if (indexi != -1)
        Console.WriteLine($"{aranacakSayi} sayısının bulunduğu index numarası: " + indexi);
    else
        Console.WriteLine("Aranan sayı dizide yok...");
    ```

5. **Kapanış:** Kullanıcı bir tuşa bastığında program sonlanır.

    ```csharp
    Console.ReadKey();
    ```
