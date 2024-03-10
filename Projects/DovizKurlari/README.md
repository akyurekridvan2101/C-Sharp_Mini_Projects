## Döviz Bilgileri Uygulaması

Bu C# konsol uygulaması, kullanıcının döviz kurlarını görüntüleyebileceği interaktif bir arayüz sunan basit bir programdır. Uygulama, kullanıcının döviz seçenekleri arasında dolaşmasına, belirli bir dövizin alış ve satış fiyatlarını görüntülemesine ve tüm dövizlerin genel bilgilerini incelemesine olanak tanır.

### Anahtar Özellikler:

1. **Döviz Seçenekleri:**
    - ABD Doları, Euro, İngiliz Sterlini gibi popüler dövizleri içeren bir dizi sunar.
    - Kullanıcıya her dövizin bir numarası ile belirli bir dövizi seçme imkanı verir.
2. **Döviz Bilgilerini Görüntüleme:**
    - Kullanıcı belirli bir döviz seçtiğinde, program web scraping kullanarak uzmanpara.milliyet.com.tr adresinden güncel döviz kurları verilerini çeker.
    - Alış ve satış fiyatlarını ekranda gösterir.
3. **Tüm Dövizleri Görüntüleme:**
    - Kullanıcı tüm dövizleri görmek istediğinde, program tüm dövizlerin alış ve satış fiyatlarını ekrana yazdırır.
4. **Kullanıcı Dostu Arayüz:**
    - Kullanıcı dostu bir menü ile kullanıcının uygulama içinde gezinmesini sağlar.
    - Kullanıcıdan alınan girişleri doğrulama ve geçersiz giriş durumlarında bilgilendirme sağlar.
5. **Çıkış İmkanı:**
    - Kullanıcı uygulamadan çıkmak istediğinde, uygulama uygun bir mesaj ile sonlanır.

### Kullanım:

1. **Döviz Seçme:**
    - Kullanıcı, ekrandaki menüden istediği dövizi seçer.
    - "0" tuşu ile tüm döviz bilgilerini görebilir.
    - "99" tuşu ile uygulamadan çıkabilir.
2. **Döviz Bilgilerini Görüntüleme:**
    - Seçilen döviz veya tüm dövizlerin bilgileri, uzmanpara.milliyet.com.tr adresinden canlı olarak çekilir ve ekrana yazdırılır.
    - Geçersiz seçim veya giriş durumlarında bilgilendirici mesajlar verilir.
3. **Devam Etme:**
    - Kullanıcıya devam etmek için bir tuşa basması gerektiğini hatırlatır.
    - Tuşa basıldığında kullanıcı menüye geri döner.

### Kod Yapısı:

- **Program Sınıfı:**
    - Uygulamanın ana mantığını içerir.
    - Kullanıcının seçimlerini yönetir ve ilgili işlemleri gerçekleştirir.
- **Doviz Sınıfı:**
    - Alış ve satış fiyatlarını içeren bir nesne modeli sağlar.
- **DovizBilgisiniGetir Metodu:**
    - HtmlAgilityPack kullanarak web scraping ile döviz bilgilerini çeker.
    - Belirtilen XPath ile hedef elementi seçer.
- **DovizIsimleri Dizisi:**
    - Programın kullanıcıya sunacağı döviz seçeneklerini içerir.