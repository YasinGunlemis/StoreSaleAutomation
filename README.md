# StoreSaleAutomation

İlk olarak STORE.bacpac database dosyasını SQL'e yükle SQL-> Databases -> Sağ Tık -> Import data-Tier Application -> Import from local disk

Server Connection için Solution->DataAccess->Abstract->SqlService

readonly string connectionString = "Data Source=YOURSERVERNAME;Initial Catalog=STORE;Integrated Security=True";
