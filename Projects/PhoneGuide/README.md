# **Telefon Rehberi Uygulaması**

Bu basit konsol uygulaması, bir telefon rehberi işlevi görmektedir. Kullanıcı, rehberine kişi ekleyebilir, kişi güncelleyebilir, kişi silebilir ve rehberdeki tüm kişileri görebilir.

## **Kullanım**

### **1. Başlangıç**

- **JSON Dosyası:** Uygulama, verileri depolamak için **`data.json`** adında bir JSON dosyası kullanmaktadır. Bu dosya, uygulamanın her başlatıldığında mevcut rehber verilerini okumasına ve yazmasına olanak tanır.

### **2. Menü**

Uygulama, kullanıcıya aşağıdaki seçenekleri içeren bir menü sunar:

- **1. Kişi Ekle:** Yeni bir kişi eklemek için bu seçeneği kullanın.
- **2. Kişi Güncelle:** Var olan bir kişiyi güncellemek için bu seçeneği kullanın.
- **3. Kişi Sil:** Var olan bir kişiyi silmek için bu seçeneği kullanın.
- **4. Rehberi Göster:** Rehberdeki tüm kişileri listeleyin.
- **5. Çıkış:** Uygulamadan çıkış yapın ve mevcut rehber verilerini JSON dosyasına kaydedin.

### **3. İşlemler**

### 3.1. Kişi Ekleme

- **Ad, Soyad ve Telefon Bilgisi:** Yeni bir kişi eklerken, kullanıcıdan ad, soyad ve telefon numarası bilgilerini girmesi istenir.
- **Rehber Güncellenir:** Yeni kişi, telefon rehberine eklenir ve ekrana "Yeni kişi telefon rehberine eklendi." mesajı yazdırılır.

### 3.2. Kişi Güncelleme

- **Güncellenecek Kişi Seçimi:** Güncellenmesi istenen kişinin adını girmesi istenir.
- **Yeni Bilgiler:** Yeni soyad ve telefon numarası bilgilerini girmesi istenir.
- **Rehber Güncellenir:** Kişi güncellenir ve ekrana "Kişi güncellendi." mesajı yazdırılır.

### 3.3. Kişi Silme

- **Silinecek Kişi Seçimi:** Silinmesi istenen kişinin adını girmesi istenir.
- **Rehber Güncellenir:** Kişi rehberden silinir ve ekrana "Kişi silindi." mesajı yazdırılır.

### 3.4. Rehberi Gösterme

- **Alfabetik Sırayla Liste:** Rehberdeki tüm kişiler alfabetik sıraya göre ekrana yazdırılır.

### **4. Çıkış**

Uygulamadan çıkarken, mevcut rehber verileri **`data.json`** dosyasına kaydedilir.

## **Kod Yapısı**

Uygulama, C# programlama dilinde yazılmıştır ve aşağıdaki temel sınıfları içerir:

- **Program:** Kullanıcı arayüzü ve temel işlevselliği içerir.
- **Kisi:** Bir kişiyi temsil eden sınıf.
- **TelefonRehberi:** Bir liste içindeki kişileri yöneten sınıf.