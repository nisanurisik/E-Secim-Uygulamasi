# E-Seçim

E-Seçim, elektronik seçim süreçlerini yönetmek için tasarlanmış kapsamlı bir web uygulamasıdır. Seçim yönetiminden oy kullanma ve sonuç takibine kadar tüm süreçleri kolaylaştırmayı hedefler.

## Projenin Amacı
Bu proje, elektronik seçim süreçlerini modern ve kullanıcı dostu bir arayüzle dijitalleştirerek aşağıdaki alanlarda hizmet sunar:
- **Seçim Yönetimi**: Seçim oluşturma ve süreçlerin takibi
- **Aday Yönetimi**: Aday ekleme, düzenleme ve listeleme
- **Kullanıcı (Seçmen) Yönetimi**: Seçmenlerin kaydı ve doğrulama işlemleri
- **Oy Kullanma Sistemi**: Güvenli ve şeffaf bir şekilde oy kullanma
- **Seçim Sonuçlarının Takibi**: Anlık seçim sonuçları raporlaması

## Kullanılan Teknolojiler
- **Framework ve Programlama Dili**:
  - ASP.NET MVC Framework
  - C# Programlama Dili
- **Veritabanı ve ORM**:
  - Entity Framework
  - SQL Server
- **Mimari ve Tasarım**:
  - Generic Repository Pattern (Tekrarlanan kodların önlenmesi)
  - Unit of Work Pattern (Transaction yönetimi)
  - DbContext Yaşam Döngüsü Yönetimi
  - Lazy Loading (İlişkisel verilerin gerektiğinde yüklenmesi)

## Temel Özellikler

### Seçim Yönetimi
- Yeni seçim oluşturma
- Seçim bilgilerini güncelleme
- Seçim süreci takibi

### Aday Yönetimi
- Aday ekleme, düzenleme ve silme
- Aday listesi görüntüleme

### Kullanıcı Yönetimi
- Seçmen kaydı
- Kullanıcı giriş ve doğrulama sistemi

### Oy Kullanma Sistemi
- Oy kullanma ekranı
- Kullanıcı doğrulama ve seçim güvenliği

### Seçim Sonuçları
- Seçim sonuçlarının anlık takibi
- Raporlama ve analiz özellikleri

## Güçlü Yönler
- **Generic Repository Pattern**: Tekrarlanan kod önlenerek temiz ve sürdürülebilir kod yapısı sağlanmıştır.
- **Unit of Work Pattern**: Transaction yönetimi optimize edilmiştir.
- **Lazy Loading**: Performans artışı sağlanmıştır, ilişkisel veriler gerektiğinde yüklenir.
- **DbContext Yönetimi**: Veritabanı işlemleri için yaşam döngüsü kontrolü yapılmıştır.

