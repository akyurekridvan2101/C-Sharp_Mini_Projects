## Gönderilen fotoğraftaki C# programlama ödevi detaylı anlatımı:

**Ödev:**

Bir müşteri, birlikte çalıştığı yazılım firmasından kişilere özel bir takvim geliştirmesini istemektedir. Bu takvim sistemi aşağıdaki özelliklere sahip olmalıdır:

**Kullanıcı Bilgileri:**

- Adı
- Soyadı
- Telefon numarası
- Cinsiyeti
- Doğum tarihi

**Takvim Sistemi:**

- Bayanlar için hafta 5 günden, baylar için ise 8 günden oluşmaktadır.
- 18 yaşından gün almış olanlar için aylar 5 hafta, diğerleri için ise 6 hafta olmaktadır.
- Kullanıcılar dinamik olarak x gün sonra bir işinin olduğunu girebilecektir.

**Yazılımın Çıktısı:**

- "Sayın "... isimli ... soy isimli..
bey/hanım (cinsiyet bilgisine göre yazmalı)... yaşındasınız... ayının... gününde işiniz bulunmaktadır"

**Ay ve Gün İsimleri:**

- Ay isimleri: 1. ay, 2. ay 3. ay....
- Gün isimleri: 1. gün, 2. gün....

**Örnek:**

- Kullanıcı Adı: Ayşe
- Kullanıcı Soyadı: Yılmaz
- Kullanıcı Telefonu: 555-555-5555
- Kullanıcı Cinsiyeti: Bayan
- Kullanıcı Doğum Tarihi: 01.01.2005
- Kullanıcı Girişi: 10 gün sonra bir işim var

**Yazılım Çıktısı:**

`Sayın Ayşe Yılmaz hanım, 19 yaşındasınız, 3. ayın 11. gününde işiniz bulunmaktadır.`