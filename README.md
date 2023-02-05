# StoreSaleAutomation

Masaüstü Mağaza satış uygulaması; geliştirilmeye açık, eksikleri mevcut olabilir.


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
- Seçilen müşteri hariç listede var olan aynı TC'ye sahip personeli güncelleyemezsin

![image](https://user-images.githubusercontent.com/95411819/216811217-0da6dd44-98a3-4f8b-9be0-fa6e65e20094.png)

**-------------FİRMA BANKA HESAPLARI-------------**

- Kayıtlı olan firmaların banka hesaplarını ekleyebilir, güncelleyebilir ve silebilirsin
- Aynı hesap no'ya sahip firma ekleyemezsin
- Seçili firma hariç listede mevcut aynı hesap noya sahip firmayı güncelleyemezsin

![image](https://user-images.githubusercontent.com/95411819/216811352-932bcb89-7b29-4b0f-b050-3a3d189b7b6b.png)

**-------------GİDERLER-------------**
- Aylık giderleri ekleme, güncelleme ve silme işlemleri yapabilirsin
- Mevcut tarihleri ekleyemezsin
- Seçili tarih hariç listede mevcut tarih giderleri güncelleyemezsin

![image](https://user-images.githubusercontent.com/95411819/216811462-993c4733-1762-49f0-853c-02fca2bfefd7.png)

**-------------REHBER-------------**
- Mevcut firma ve kişilerin iletişim bilgilerini listeler
- Satırbaşına tıklayarak mesaj gönderme ekranına ulaşabilirisn
- 
![image](https://user-images.githubusercontent.com/95411819/216811822-f4e3a5c9-f955-48ab-91e8-54d6ff9fd7e7.png)


**-------------FATURALAR-------------**
- Mevcut müşterilere (firma ve kişiler) fatura açabilir, mevcut ürünlerden seçebilir ve sepete ekleyebilirsin
- Sepete eklenen ürünü silebilirsin
- Sepete ekleme ve çıkarma işlemi yaptığında ürün sayısı artar ve ya azalır
- Faturayı sadece ekleyebilirsin güncelleme ve silme yapamazsın
- Faturadaki ürünleri alt tablosunda görebilirsin

![image](https://user-images.githubusercontent.com/95411819/216811990-2c087736-d9e3-41fc-b727-483a0fce18cd.png)

**-------------NOTLAR-------------**
- Not ekleme-güncelleme-silme işlemleri yapabilirsin

![image](https://user-images.githubusercontent.com/95411819/216812063-dcf7a487-de5b-44ab-89f7-4f4c791c183e.png)

**-------------GRAFİKLER-------------**

**Ürünler-Adet**
- Mevcut ürünlerin dağılımını görebilirsin
![image](https://user-images.githubusercontent.com/95411819/216812136-f7bc3eff-31c4-44fa-8c4e-5a2d9feba09f.png)

**Marka-Adet**
- Mevcut ürünlerin seçilen ürüne göre marka dağılımını görebilirsin
![image](https://user-images.githubusercontent.com/95411819/216812200-1820ce2a-3d78-449f-b2d4-5f5f84665a7a.png)

**Satışlar En Çok Satanlar**
- En çok satan ilk 10 ürün grafiği

![image](https://user-images.githubusercontent.com/95411819/216812312-39518109-2940-40b4-ba4d-fb20a9ca2195.png)

**Satışlar En Az Satanlar**
- En az satan ilk 10 ürün grafiği
![image](https://user-images.githubusercontent.com/95411819/216812375-639803b7-36bd-44d2-878b-c2d850e69785.png)

