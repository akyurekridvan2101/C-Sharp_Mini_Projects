**Binary Converter Uygulaması**

Bu C# programı, kullanıcıdan alınan metin girişini binary formata çevirerek ekrana yazdıran basit bir uygulamadır.

**Neden 2'nin Üsleri Kullanıldı**

2'nin üsleri, matematikte ve bilgisayar biliminde sıkça kullanılan bir kavramdır. Bu kavram, temelde 2'nin bir kuvveti olarak ifade edilen sayılardır. 2'nin üsleri, bir sayının kendisiyle kaç kez çarpıldığını ifade eder. Genel olarak, 2 üzeri n (2^n), 2'yi n kez kendisiyle çarptığımız anlamına gelir.

Örneğin:

2 üzeri 0 (2^0) = 1
2 üzeri 1 (2^1) = 2
2 üzeri 2 (2^2) = 2 * 2 = 4
2 üzeri 3 (2^3) = 2 * 2 * 2 = 8
ve böyle devam eder.
Bu kavram, bilgisayar biliminde özellikle binary (ikili) sistemde sıkça kullanılır çünkü bilgisayarlar genellikle ikili (binary) sayı sistemini kullanırlar. Her bir bit, 2'nin bir kuvveti olarak düşünülebilir. Örneğin, 8-bitlik bir binary sayı, 2^7'den 2^0'a kadar olan 8 farklı 2'nin üslerini kullanarak oluşturulabilir.

Fonksiyon içinde 2'nin üsleri, Math.Pow(2, i) ifadesiyle kullanılmıştır. Bu ifade, 2'nin i kadar üssünü hesaplar. Fonksiyon, bu üsleri kullanarak karakterin ASCII değerini binary formata çevirir.






**Nasıl Kullanılır?**

1. Programı başlatın.
2. Kullanıcıdan metin girişi istenecektir. Bir metin girin ve Enter tuşuna basın.
3. Program, her bir karakterin ASCII değerini alarak bunları binary formata çevirip ekrana yazdıracaktır.

**Not ⇒** Dikkat edilmesi gerekn konu C# diğer çoğu dil için bir karaktere 1 byte ayırmaz her karakter için 2 byte yani 16 bit ayırır.Bu durumu da göz önünde bulundurarak kodladım.

**Örnek**

```bash
Metin girin: Hello
0000000001001000
0000000001100101
0000000001101100
0000000001101100
0000000001101111
```

Yukarıdaki örnekte, "Hello" metni girildiğinde, her karakterin ASCII değeri alınarak binary formata çevrilmiştir.

**Notlar**

- Eğer boş bir metin girilirse, "Metin girilmediği için çevrilemedi..." şeklinde bir hata mesajı alırsınız.
- Her bir karakterin binary temsilini oluşturan **`CharToBits`** metodunu kullanarak bu işlem gerçekleştirilir.
- ASCII değerine göre her bir karakterin binary temsilini oluşturan mantık, programın içerisinde detaylı olarak açıklanmıştır.
- Program, metindeki her bir karakterin binary temsilini ters sırayla ekrana yazdırır.