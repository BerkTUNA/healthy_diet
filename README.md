# Yazılım Mimarisi ve Tasarımı
# *Healthy Diet Projesi *

## Projeyi Yapanlar
Ömer Killik - 192802045 - I.Ogretim

Berk Tuna - 182805007 - II.Ogretim

## Uygulamanın Kullanımını Anlatan Video Linki;
[Healthy Diet Projemiz]( https://youtu.be/UtFbBCJHJ1A)
# *Proje Açıklaması ve Amacı*
Healthy Diet projesi kısaca bir hasta ve diyetisyen projesidir. Diyetisyen hizmeti alan hasta istediği diyetisyene gidip kendini kaydettirebilir, muayene olup hastalığı ve kendine özel hazırlanan diyet yöntemini rapor şeklinde alabilir.
# Projemizin UML Diagramı
![USECASEDIAGRAM](https://user-images.githubusercontent.com/70074665/120934206-0a366400-c706-11eb-9a45-d9b3b922ae62.png)
# Projemizin Scrum Table'ı
![Scrum2](https://user-images.githubusercontent.com/70074665/120934192-00acfc00-c706-11eb-89ec-4d335c796fb5.png)

# Projemizin Ekran Görüntüleri ve Açıklamaları

# *VERİ TABANI*
![veritabanıdiyetler](https://user-images.githubusercontent.com/70074665/120934835-9cd80280-c708-11eb-9e08-f25601bc8a4b.png)
Diyetisyenin eklediği diyetler bu tabloya kaydediliyor

![veritabanıhastalar](https://user-images.githubusercontent.com/70074665/120934848-acefe200-c708-11eb-836c-41c11bc62598.png)

Diyetisyenin kaydettiği hastalar Diyet kısmı en başta "YOK" olarak bu tabloya kaydediliyor

![veritabanıhastalıklar](https://user-images.githubusercontent.com/70074665/120934850-b0836900-c708-11eb-89d4-8fc14d38d34c.png)

Diyetisyenin kaydettiği hastalıklar bu tabloya kaydediliyor

![veritabanıdiyetisyenler](https://user-images.githubusercontent.com/70074665/120934854-b2e5c300-c708-11eb-9357-ee80a5dc2eb3.png)
Adminin eklediği Diyetisyenler bu tabloya kaydediliyor

# *GİRİŞ*
![giriş1](https://user-images.githubusercontent.com/70074665/120935047-9dbd6400-c709-11eb-97e9-0572c17257f6.png)

Projenin başlangıç kısmı burası.Burada veri tabanındaki Diyetisyenler bölümünde Yetki sütunundaki veri eğer Diyetisyense diyetisyenin anasayfasına, Adminse admin paneline yönlendiriyor.

![giriş2](https://user-images.githubusercontent.com/70074665/120935112-da895b00-c709-11eb-9dfa-3b5726780b39.png) 

eğer hiç bir veri girilmezse

![giriş3](https://user-images.githubusercontent.com/70074665/120935122-e543f000-c709-11eb-8402-0dcfc3d4c5ec.png) 

eğer yanlış veri girilirse hataları yollanıyor

# *ADMİN PANELİ*

![admin1](https://user-images.githubusercontent.com/70074665/120935160-19b7ac00-c70a-11eb-97e9-3fb386ac38df.png)

Eğer admin giriş yaparsa admin paneli açılıyor geri tuşuna basarsa Giriş formuna "X" tuşuna basarsa program kapanıyor.

![admin3](https://user-images.githubusercontent.com/70074665/120935223-626f6500-c70a-11eb-8cc8-197851b95871.png)

Admin tüm Hastaların tüm bilgilerine erişim sağlayabiliyor

![admin2](https://user-images.githubusercontent.com/70074665/120935198-48358700-c70a-11eb-9037-f74ba7dddb72.png)

Admin tüm Diyetisyenlerin tüm bilgilerine erişim sağlayabiliyor

![admin4](https://user-images.githubusercontent.com/70074665/120935214-5be0ed80-c70a-11eb-9b3a-cfab81c0e0dd.png)

Admin yeni bir Diyetisyen kaydı oluşturabiliyor

![admin8](https://user-images.githubusercontent.com/70074665/120935287-afebd200-c70a-11eb-880a-95d0a4406100.png)

Aynı kullanıcı adında başka bir Diyetisyen varsa

![admin7](https://user-images.githubusercontent.com/70074665/120935301-bed28480-c70a-11eb-8aec-7c823cfe9b38.png)

Boş bırakılırsa

![admin5](https://user-images.githubusercontent.com/70074665/120935315-ce51cd80-c70a-11eb-9f65-6995a21d176b.png)

Combobox'ın boş olup olmadığı ayrı şekilde kontrol edilebiliyor eğer seçilmezse

![admin6](https://user-images.githubusercontent.com/70074665/120935324-df024380-c70a-11eb-823f-0a9e4b0e2b1a.png)

Şifre ve Şifre Tekrar uyuşmuyorsa hataları yollanıyor


# *Ana Sayfa*

![ana1](https://user-images.githubusercontent.com/70074665/120935394-39030900-c70b-11eb-9e28-ee6ea65feaf1.png)

Diyetisyen girişi yapıldıysa Anasayfa formu açılıyor burda tüm hastalar listeleniyor ve Diyetisyenin ismi ve Avatarı geliyor
![ana2](https://user-images.githubusercontent.com/70074665/120935424-57690480-c70b-11eb-8e4f-1ad4be8826c5.png)

Listele Filtrenebiliyor

![ana3](https://user-images.githubusercontent.com/70074665/120935440-62bc3000-c70b-11eb-82f2-bdf18cb2db0b.png)

Eğer Diyetisyenin cinsiyeti Erkekse

![ana4](https://user-images.githubusercontent.com/70074665/120935446-6fd91f00-c70b-11eb-91ab-c16cdf760a38.png)

Eğer Diyetisyenin cinsiyeti Kadınsa Avatarları çıkıyor

# *Yeni Hastalık*

![Hastalık1](https://user-images.githubusercontent.com/70074665/120935545-fa218300-c70b-11eb-97b5-d9b20ea1f163.png)

Diyetisyen burdan yeni bir hastalık ekleyebiliyor

![hastalık2](https://user-images.githubusercontent.com/70074665/120935553-03aaeb00-c70c-11eb-97d2-a2e60db70eb7.png)

Aynı isimde veri tabanında başka bir hastalık varsa 

![hastalık3](https://user-images.githubusercontent.com/70074665/120935568-145b6100-c70c-11eb-9139-f3b4191bce4e.png)

Veri girilmezse hataları yollanıyor

# *Yeni Hasta Ekle*

![hasta1](https://user-images.githubusercontent.com/70074665/120935597-394fd400-c70c-11eb-8758-d22cbf95b380.png)

Diyetisyen burdan yeni bir Hasta ekleyebiliyor

![hasta4](https://user-images.githubusercontent.com/70074665/120935694-9c416b00-c70c-11eb-806e-3b3db8048d5c.png)

Eklenen yeni Hastalıklar combobox'a geliyor

![hasta2](https://user-images.githubusercontent.com/70074665/120935658-7caa4280-c70c-11eb-8ea0-a936781aaa31.png)

Veri girilmezse

![hasta3](https://user-images.githubusercontent.com/70074665/120935674-892e9b00-c70c-11eb-9510-104680b34c16.png)

Veri tabanında aynı TC ile başka bir hasta varsa hataları yollanıyor







































