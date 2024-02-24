# **Adam Asmaca Oyunu**

Bu proje, C# programlama dilinde geliştirilmiş basit bir konsol tabanlı "Adam Asmaca" oyununu içermektedir. Oyun, bilgisayar tarafından seçilen bir kelimenin harflerini tahmin etmeye dayanmaktadır. Oyuncu, her tahmininde doğru harfleri bulmaya çalışırken, yanlış tahminlerde ise bir "adam asma" grafiği oluşturulur. Oyuncu, belirli bir hata sayısına ulaşmadan tüm harfleri doğru tahmin ederse oyunu kazanır.

## **Oyunun Çalışma Prensibi**

1. **Kelime Seçme:** Oyun, başlangıçta bir dizi içinde tanımlanan kelimeler arasından rastgele bir kelime seçer.
2. **Kelimeyi Gizleme:** Seçilen kelimenin harf sayısı kadar alt çizgi ile başlayan bir tahmin dizisi oluşturulur. Her harfin tahmin edildiğinde, bu dizide ilgili yerlere yerleştirilir.
3. **Oyun Döngüsü:** Oyun, bir döngü içinde çalışır. Oyuncu, her döngüde bir harf veya kelime tahmininde bulunabilir.
4. **Harf Tahmininde Bulunma:** Oyuncu, harf tahmininde bulunarak doğru harfleri tahmin etmeye çalışır. Tahmin edilen doğru harfler, kelimenin ilgili yerlerine yerleştirilir.
5. **Hata Kontrolü:** Yanlış tahminlerde, oyuncunun hata sayısı artar ve bir "adam asma" grafiği çizilir. Toplam 6 hata yapma hakkı vardır.
6. **Oyun Sonlandırma:** Oyun, oyuncunun tüm harfleri doğru tahmin etmesi veya belirli bir hata sayısına ulaşması durumunda sona erer.

## **Ana Fonksiyonlar ve Modüller**

- **YazdirAdamAsmacaKurallari():** Oyunun başlangıcında oyun kurallarını ve talimatlarını ekrana yazdıran fonksiyon.
- **AdamAsmacaCiz():** Oyuncunun yaptığı yanlış tahmin sayısına bağlı olarak "adam asma" grafiğini ekrana çizdiren fonksiyon.
- **HarfGuncelle():** Kullanıcının girdiği harfi kontrol eden ve doğru tahmin edilen harfleri güncelleyen fonksiyon.
- **Main():** Oyunun ana döngüsünü içeren fonksiyon. Oyunun başlangıcını, kelime seçimini, kullanıcı tahminlerini ve oyun sonlandırma durumlarını yönetir.

## **Nasıl Oynanır?**

1. Oyun başladığında, kuralları ve talimatları içeren bir ekran görüntüsü belirir. Oyunu başlatmak için herhangi bir tuşa basmanız beklenir.
2. Oyuncu, kelimenin harf sayısını tahmin eder ve ardından her tahminde bir harf veya kelime girebilir.
3. Doğru tahminler, kelimenin ilgili yerlerine yerleştirilirken; yanlış tahminlerde "adam asma" grafiği çizilir.
4. Oyuncu, tüm harfleri doğru tahmin ederse veya belirli bir hata sayısına ulaşırsa oyun sonlanır ve sonuç ekrana yazdırılır.

## **Nasıl Çalıştırılır?**

1. Projeyi bir C# derleyicisi ile derleyin (Visual Studio, VS Code, vb.).
2. Derlenen programı çalıştırarak oyunu başlatın.
3. Kuralları takip ederek harfleri veya kelimeyi tahmin edin.
4. Sonucu ekranda gözlemleyin: Kazandınız mı, kaybettiniz mi?