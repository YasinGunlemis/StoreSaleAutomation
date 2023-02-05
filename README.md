# StoreSaleAutomation

İlk olarak STORE.bacpac database dosyasını SQL'e yükle SQL-> Databases -> Sağ Tık -> Import data-Tier Application -> Import from local disk

Server Connection için Solution->DataAccess->Abstract->SqlService

readonly string connectionString = "Data Source=YOURSERVERNAME;Initial Catalog=STORE;Integrated Security=True";

**------------GİRİŞ EKRANI------------**

Eğer giriş yapan personel yetkili değilse ana ekranda giderler ve firma banka hesapları butonları gözükmeyecek

![1](https://user-images.githubusercontent.com/95411819/216808902-e0558beb-cb08-4dfd-bf2b-ec38f0d278c9.jpg)

-İşçi Girişi
![2](https://user-images.githubusercontent.com/95411819/216809912-195afdda-bde6-48a0-9719-f19696400380.jpg)
-Yetkili Girişi
![3](https://user-images.githubusercontent.com/95411819/216809914-97bd20fc-0d42-4e42-9a21-a9318a8cc412.jpg)

**-------------ANASAYFA-------------**

Anasayfa ekranı belli bir miktardan az kalan ürünleri ve son eklenen ürünleri comboboxtaki sayıya göre görebilirsin. Günlük kurları, haberleri ve hava durumunu kontrol edebilirsin.
![image](https://user-images.githubusercontent.com/95411819/216810512-44cc1fed-1bac-447e-9994-8c6f5ca4a9f4.png)

**-------------PERSONELLER-------------**

- Personel Ekleme-Güncelleme-Silme işlemleri yapabilirisin 
- Personeli resim olmadan NULL olarak SQL'e kayıt edebilir ve sonradan resim ekleyerek güncelleyebilirsin
- Gerekli bilgiler olmadan kayıt yapamazsın 
- Aynı TR-ID (TC) ye sahip personel kayıt edemezsin
- Seçilen personel hariç listede var olan ya da silinmiş aynı TC'ye sahip personeli güncelleyemezsin
![image](https://user-images.githubusercontent.com/95411819/216810569-a9dde1fc-56d7-4292-83d0-36ed9ffbcb1b.png)

**-------------ÜRÜNLER-------------**

- Ürün Ekleme-Güncelleme-Silme işlemleri yapabilirisin 
- Ürün resimleri için resimsiz bir şekilde NULL olarak ya da en fazla 3 resim olacak şekilde SQL'e kayıt edebilir ve sonradan resim ekleyerek güncelleyebilirsin
- Gerekli bilgiler olmadan kayıt yapamazsın 
![image](https://user-images.githubusercontent.com/95411819/216810774-ef741f3b-aad4-4bbe-ab2b-d3eedf507a02.png)

**-------------FİRMALAR-------------**

- Firmalar sayfasından firma ekleme sayfasına gidebilir, seçili firmayı silebilir ve detaylar sütunundan firma detaylarına gidip güncelleme işlemleri yapabilirsin
- Aynı vergi no'ya sahip firma ekleyemezsin
- Güncelleme ekranında seçilen firma hariç listede mevcut aynı vergi noya sahip firmayı güncelleyemezsin

![image](https://user-images.githubusercontent.com/95411819/216810963-3b1c1116-22eb-4987-a8e2-7aa53f4616e1.png)

- Firma Ekleme Ekranı

![image](https://user-images.githubusercontent.com/95411819/216811058-c58b2871-1ad0-4866-b59a-30f51d77784d.png)

- Firma Detaylar Ekranı ve Güncelleme

![image](https://user-images.githubusercontent.com/95411819/216811107-19fb1bc4-68c0-4c09-9a7f-f56c8fd22f5f.png)

**-------------MÜŞTERİ KİŞİLER-------------**
- Müşteri Ekleme-Güncelleme-Silme işlemleri yapabilirisin 
- Gerekli bilgiler olmadan kayıt yapamazsın 
- Aynı TR-ID (TC) ye sahip müşteri kayıt edemezsin
- Seçilen müşteri hariç listede var olan ya da silinmiş aynı TC'ye sahip personeli güncelleyemezsin

![image](https://user-images.githubusercontent.com/95411819/216811217-0da6dd44-98a3-4f8b-9be0-fa6e65e20094.png)
