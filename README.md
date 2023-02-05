# StoreSaleAutomation

İlk olarak STORE.bacpac database dosyasını SQL'e yükle SQL-> Databases -> Sağ Tık -> Import data-Tier Application -> Import from local disk

Server Connection için Solution->DataAccess->Abstract->SqlService

readonly string connectionString = "Data Source=YOURSERVERNAME;Initial Catalog=STORE;Integrated Security=True";

Giriş Ekranı
Eğer giriş yapan personel yetkili değilse ana ekranda giderler ve firma banka hesapları butonları gözükmeyecek

![1](https://user-images.githubusercontent.com/95411819/216808902-e0558beb-cb08-4dfd-bf2b-ec38f0d278c9.jpg)

