# MyAPIProject
## Asp.Net Core Api - Rapid Api ve Api Proje

Bu projeyi Murat Yücedağın Udemyde yayınlanan Asp.Net Core Api - Rapid Api ve Api Consume kursu referans alarak 200 derste hazırladım.

AspNet Core ile Api işlemlerini sıfırdan gerçekleştirdiğim bu projede Restful Api yapısını, Apilerin nasıl consume edildiğini, Rapid Api yapısını ve consume edilmesini proje üzerinden uygulamalı olarak gerçekleştirerek 24 saat uzunluğundaki bu eğitimi tamamlayıp aşağıdaki sertifikayı almaya hak kazandım.


Eğitime dilerseniz [bu linkten](https://www.udemy.com/share/108lA23@GiXLllDN1Gg-v3GUq1XK0RdiVkVNszJ96cgkwvW9Fx9AvLihZpANBg0EDnFTuChE/) ulaşabilirsiniz.




### Giriş ve Katmanların Oluşturulması

Giriş yapılarak proje oluşturuldu.

Dto Katmanı ve Frontend kısmı hazırlanarak entityler oluşturuldu.

Paketlerin kurularak referans haritası oluşturuldu. Referans işlemleri yapıldı.

Migration işlemleri yapıldı.

Abstract Interaces, Generic Repository, Ef Classları, Service ve Managerler oluşturuldu.



### Swagger ve Apinin Kodlanması

Swaggerlara giriş yapılarak test işlemleri gerçekleştirildi.

Staff Controller hazırlanarak kalan controllerların yazıldı.

Tema yüklenerek Layout hazırlandı. Partiallar ayarlandı.



### Api Cors ve Consume İşlemleri

Api Cors ve Apinin Consume edilmesi işlemleri gerçekleştirildi.

Personel verilerinin listelenmesi, yeni personel eklenmesi, personelin silinmesi, güncellenecek verilerin sayfaya taşınması ve personelin güncellenmesi işlemleri yapıldı.



### Referans İşlemleri

Referans controller oluşturuldu.



### Dto Katmanı

Dto sınıfıları oluşturuldu.

Auto Mapper ayarlandı.

Odanın Mapper kontrolü yapıldı.

Ekleme test edilmesi. 

Update Dto testi yapıldı.



### Hizmetler

Hizmet Dtoları oluşturuldu. Hizmet listesi, hizmetlerin eklenmesi, silinmesi ve güncellenmesi işlemleri gerçekleştirildi.



### Identity Kütüphanesi - Register ve Login

Identity kütüphanesi eklendi.

Register Dto oluşturuldu.

Register ve Login İşlemi gerçekleştirildi.



### Api için Frontend Tasarımı

Frontend teması eklendi.

View Component ve Default Partial Views eklendi.

Ana sayfada düzenlemeler yapılarak

About, odalar, trailer düzenlemesi, hizmetlerimiz, referanslar, takım arkadaşlarımız sayfaları hazırlandı.

Mail bültenine abone olma işlemi gerçekleştirildi.

Footer düzenlemesi yapıldı.



### Rezervasyon Sayfaları

Booking sayfası, booking tablosu, booking ekleme sayfası oluşturularak booking işlemi gerçekleştirildi.



### Diğer Sayfalar

Booking admin sayfası yapıldı.

Durum butonlarının eklenmesi, rezervasyon durumunun değiştirilmesi, entitye özgü metotların yazılması, aynı Attributelerin birden fazla yerde kullanılması, rezervasyonda Id'ye göre düzenlemelerin yapılması işlemleri gerçekleştirildi.



### Rapid Api

Rapid Api'ye giriş yapıldı.

Apiye abone olma, Apinin Json olarak gösterilmesi işlemlerine bakıldı.

Film verilerinin tabloda gösterilmesi işlemi, döviz kur Apisi ile veri çekme işlemleri gerçekleştirildi.

BookingCom otel Api, Booking Api Consume, Search Location ID APi, parametreli Api consume bakıldı.

Parametreye göre otel getirme işlemleri yapıldı.



### Json Web Token

Jwt giriş yapıldı. Jwt Bearer paketi yüklendi. Jwt Konfigürasyonu yapıldı.

Token oluşturma sınıfı oluşturuldu.

Postman üzerinden token oluşturma işlemi yapıldı.

Token ile Auhtorize yapıldı. Clockskew ayarlandı. 

Admin için Token oluşturma işlemi yapılarak Token testi gerçekleştirildi.



### Projeyle Alakalı Eksiklerin Tamamlanması

Eksikler belirlenerek ana sayfadaki eksikler giderildi.

Guest sınıfı eklendi.

Tetikleyiciler yazıldı.



### İletişim Paneli

İletişim paneli oluşturularak sayfanın testi yapıldı.

Map eklendi.



### Hakkımızda ve Odalar

Admin About işlemleri, room işlemleri, guest işlemleri gerçekleştirildi

Misafir Apisi consume edildi.



### FLuent Validation

Fluent Validation kuruldu. Validasyona göre işlemler ayarlandı. Guest Update Fluent Validation yapıldı.



### Mesaj İşlemleri

Mesaj sayfası, giden mesaj sayfası, Mesaj Detayları Sayfası, Gelen Mesaj Detayları hazırlandı.

Gelen mesaj ve giden mesaj listesi yapıldı. Yeni mesaj gönderme işlemi gerçekleştirilerek mesaj işlemleri tamamlandı.

Tasarımsal iyileştirmeler, ikon düzenlemeleri ve tarih formatlarının ayarlanması yapıldı.



### Mail İşlemleri

Mail hazırlığı, uygulama şifresi alma ve  mail gönderme işlemleri yapıldı.



### Api Dosya İşlemleri

Api Dosya işlemleri backend kısmı yapıldı. Postman üzerinden Api dosya işlemi File Consume backend gerçekleştirildi.

Api Frontend ile test edildi.

Api ile metin belgesi yükleme işlemi yapıldı.



### Authorize ve AllowAnonymous

Proje seviyesinde authorize işlemleri yapıldı.

Login Path, AllowAnonymous ayarlandı.

404 Error Sayfası oluşturuldu.



### Mesajlar

Gelen mesaj sayısı ve gönderilen mesaj sayısı Api ile çekildi.

Apiden çekilen mesaj sayısı bilgisi Consume edildi.



### İlişkili Tablolar

İlişkili tablolar oluşturuldu.

Message Category sınıfı Api Crud işlemleri yapıldı.

Dropdown aracı için Backend kodu yazılarak ilişkili başlıklar çekildi.



### WorkLocation

Kullanıcı listesi oluşturularak kullanıcılarda düzenlemeler yapıldı.

İkon listesi incelendi.

WorkLocation tablosu ve Api list oluşturuldu.

Lokasyon listesi oluşturuldu.

Identity'i Api ile tüketme işlemi gerçekleştirildi.

Referance Loop Handling oluşturuldu.

Kullanıcıları WorkLocation bilgisi ile listeleme işlemi yapıldı.

Kullanıcıların listelenerek kullanıcıların görselleri çekildi.

Kullanıcı tablosunda tasarımsal iyileştirmeler yapıldı. Cinsiyet ve ülke sütunları eklendi.

Indexte karar yapısı kullanıldı.



### Entitye Özgü Metotlar ile Çalışmak

Kullanıcıları lokasyon ile getirme işlemi yapıldı.

Çalışanlar lokasyonları ile listelendi.



### Dashboard

Dashboarda genel bakış yapıldı. Dashboard düzenlemeleri yapılarak tasarımı yapıldı.

Staff Get Count işlemi yapıldı.

Apiden çekilen istatistik Consume edildi.

Api İstatistik Consume işlemleri yapıldı.

Ayın tam ismi getirildi.

Widgetlar tamamlandı.

Son 4 personel Api ile getirildi.

Son 6 rezervasyon listesi çekildi.

Durumlara göre status renkleri ayarlandı.

City ve country bilgisi eklendi.



### Sosyal Medya Takipçi Sayılarını Api ile Çekme

Instagram API incelenerek Instagram takipçi sayısı API ile çekildi. Takipçi sayılarının Viewbag'lere taşınması sağlandı.

İç İçe 3 Nested Json yapısı oluşturuldu.

Linkedin takipçi sayısı çekildi.



### Rol İşlemleri

Rol listesi oluşturularak rol ekleme, silme ve düzenleme işlemleri gerçekleştirildi.



### Rol Atamaları

Rol atanacak kullanıcı listesi ve kullanıcının sahip olduğu rol listesi oluşturuldu.

Rol atama tasarım sayfası oluşturularak rol atama işlemi gerçekleştirildi.

Profil bilgilerinin güncellenmesi işlemi sağlandı. 



### Rezervasyonların Api Üzerinden Çekilmesi

Rezervasyunun Api ile onaylanması sağlandı.

Rezervasyon iptali, rezervasyon bekletme ve rezervasyonların güncellenmesi işlemleri yapıldı.



### Finalde proje canlıya alma aşamasıdır. Proje henüz canlıya alınmamıştır.



![Sertifika Resmi](https://resmim.net/cdn/2023/08/22/SVxlXK.jpg)
