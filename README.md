<h1>E-Seçim Uygulaması</h1>

Bu uygulama ASP.NET MVC ve MSSQL veritabanı kullanılarak geliştirildi.

Projede yönetici, seçmen ve aday olarak 3 farklı kullanıcı bulunmaktadır.

Kullanıcıların bilgileri veritabanında tutulmaktadır ve giriş ekranında bu bilgiler kontrol edilerek giriş sağlanmaktadır.

Giriş yapan kullanıcıların yetki durumları vardır. Bu yetki durumları sayesinde tüm sayfaları görüntüleyemezler ve her işlemi yapamazlar.

Seçmenler; aday listeleme, kampanya listeleme ve oy kullanma yetkilerine sahiptirler.

Adaylar; kampanya ekleme, aday listeleme, kampanya listeleme ve oy kullanma yetkilerine sahiptirler.

Yöneticiler; seçim ekleme, kullanıcı ekleme, aday ekleme,  aday listeleme, kampanya listeleme ve oy kullanma yetkilerine sahiptirler.

Kullanıcıların veritabanında oy durumlarını tutan bir değer vardır. İlk başta bu değer sıfır iken oy kullanınca bu değer bir olmaktadır.



