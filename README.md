# 📝 TodoList Web API - Enterprise Architecture

Bu proje, modern yazılım mimarisi prensipleri ve en güncel **.NET 9.0** teknolojileri kullanılarak geliştirilmiş, ölçeklenebilir ve sürdürülebilir bir **Task Management API** çalışmasıdır. Projede **Clean Architecture** (Temiz Mimari) yaklaşımı benimsenmiş ve karmaşıklığı yönetmek için **CQRS (MediatR)** deseni uygulanmıştır.



## 🛠️ Teknik Stack & Teknolojiler

* **Framework:** .NET 9.0
* **Mimari:** Clean Architecture (N-Layer)
* **Pattern:** CQRS (Command Query Responsibility Segregation)
* **Kütüphaneler:**
    * **MediatR:** Katmanlar arası gevşek bağlılık (loose coupling) için.
    * **Entity Framework Core 9.0:** Code-First yaklaşımı ile veritabanı yönetimi.
    * **AutoMapper:** Nesne dönüşümleri (DTO <-> Entity) için.
    * **Scalar / OpenAPI:** Modern ve etkileşimli API dokümantasyonu.
    * **Minimal API:** Performanslı ve hafif endpoint yönetimi.

## 🏗️ Proje Katmanları (Solution Structure)

Proje, sorumlulukların ayrılması (**Separation of Concerns**) ilkesine uygun olarak 4 ana projeden oluşmaktadır:

1.  **`ToDoListApi.Domain`:** Varlıklar (Entities) ve temel iş kuralları. (`Category`, `ToDoItem`)
2.  **`ToDoListApi.Application`:** İş mantığı, DTO'lar, MediatR Command/Query Handler'lar, Mapping profilleri ve Interface'ler.
3.  **`ToDoListApi.Infrastructure`:** Veritabanı konfigürasyonu, DbContext, Migrations ve Repository implementasyonları.
4.  **`ToDoListApi.Presentation` (Web API):** Minimal API endpoint tanımlamaları, Program.cs yapılandırması ve giriş katmanı.



## 🚀 API Özellikleri ve Endpoint'ler

Proje kapsamında `Category` ve `ToDoItem` sınıfları için tam kapsamlı **CRUD** operasyonları sunulmaktadır:

* **Get All:** Tüm kayıtları listeleme.
* **Get By Id:** ID bazlı tekil kayıt sorgulama.
* **Create:** Yeni kayıt ekleme.
* **Update:** Mevcut kaydı güncelleme.
* **Delete:** Kayıt silme.

## 🏁 Kurulum ve Çalıştırma

1.  Projeyi klonlayın:
    ```bash
    git clone [https://github.com/Spacend00/TodoList-WebAPI.git](https://github.com/Spacend00/TodoList-WebAPI.git)
    ```
2.  `Infrastructure` katmanındaki Connection String bilgilerini yerel veritabanınıza göre güncelleyin.
3.  Veritabanını oluşturmak için Package Manager Console üzerinden şu komutu çalıştırın:
    ```bash
    Update-Database
    ```
4.  Projeyi çalıştırdıktan sonra tarayıcınızdan `/scalar/v1` adresine giderek API'yi test edebilirsiniz.

---
*Bu proje modern backend geliştirme pratiklerini uygulamak amacıyla geliştirilmiştir.*

Developed by [Mehmet Gündüz]