# Zar Oyunu

## Açıklama
Bu C# programı, bir zar oyununu simüle eder ve iki oyuncunun zar atarak puan kazandığı basit bir oyunu içerir. Oyuncular, sırayla zar atar ve her atış sonucunda aldıkları sayılar toplanarak toplam puanlarına eklenir. Oyunculardan biri 50 puana ulaştığında oyun sona erer ve kazanan belirlenir.

## Oyun Kuralları
- Her iki oyuncu için ortak bir zar kullanılır, böylece zar yüzleri aynıdır.
- Oyuncular sırayla zar atar ve aldıkları sayılar toplam puanlarına eklenir.
- Oyunculardan biri 50 puana ulaştığında oyun sona erer.
- Oyun sonunda kazanan belirlenir ve ekrana sonuçlar yazdırılır.

## Zar Sınıfı
1. Zar sınıfı, zar oyununda kullanılan zar nesnesini temsil eder.
2. Zarın yüzlerine farklı sayılar atanır, rastgele sayı üretme işlemi gerçekleştirilir.
3. Her oyuncu için aynı zar nesnesi kullanılarak adil bir oyun sağlanır.

## Oyuncu Sınıfı
1. Oyuncu sınıfı, zar oyununda bir oyuncuyu temsil eder.
2. Oyuncunun adı ve toplam puanı özellik olarak bulunur.
3. Oyuncunun puanını zar atarak artıran bir metot içerir.

## Program Akışı
1. Zar nesnesi oluşturulur ve oyuncu isimleri kullanıcıdan alınır.
2. Oyun başlar, her iki oyuncu sırayla zar atar ve puanlarına eklenir.
3. Anlık puanlar ekrana yazdırılır.
4. Oyun devam eder ve bir oyuncu 50 puana ulaştığında sona erer.
5. Sonuçlar ekrana yazdırılır, kazanan belirlenir.

## Örnek Kullanım
1. Oyuncu 1 Adı: [Oyuncu adını girin]
2. Oyuncu 2 Adı: [Diğer oyuncu adını girin]
3. Oyuna başlamak için herhangi bir tuşa basın.
4. Oyuncular sırayla zar atar, puanları görüntülenir.
5. Oyun devam eder ve bir oyuncu 50 puana ulaştığında sona erer.
6. Sonuçlar ekrana yazdırılır.

## Notlar
- Oyunun sürekli olarak devam etmesi için sonsuz döngü kullanılmıştır.
- Oyunun okunabilirliğini artırmak için zar atma anında kısa bir bekleme süresi eklenmiştir.
- Oyunun sonuçları renkli bir şekilde ekrana yazdırılmıştır.
