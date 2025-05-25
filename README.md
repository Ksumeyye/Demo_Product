<b> Demo_ Product <7b> <br>
Bu projede, ASP.NET Core MVC mimarisiyle çok katmanlı (N Katmanlı) bir web uygulaması geliştirdim. Uygulamada ürün ve müşteri yönetimi, kullanıcı kayıt/giriş işlemleri ve ilişkilendirilmiş veri yönetimi gibi temel modüller yer almaktadır. <br>

🚀 Proje Başlangıcı & Temeller<br>
Projenin başlangıcında metot, property ve entity gibi temel kavramları öğrenerek ilerledim. DbContext sınıfı ve Code First Migration yapısını kullanarak veritabanını oluşturdum. Erişim belirleyiciler, parametreli metotlar ve kalıtım gibi OOP (nesne yönelimli programlama) kavramlarını uyguladım. Kod yapısını tasarımsal olarak iyileştirdim.<br>

🛒 Ürün İşlemleri<br>
Ürünleri listeledim, ekledim, sildim ve güncelledim.<br>

Her bir işlem için ayrı controller metotları, view dosyaları ve validasyonlar oluşturdum.<br>

👥 Müşteri İşlemleri<br>
Müşterilere özel controller ve view yapıları hazırladım.<br>

Controller içinde şart kontrolleri uygulayarak veri güvenliğini sağladım.<br>

🧱 N Katmanlı Mimari<br>
Projeyi 3 ana katmanda yapılandırdım:<br>

Entity Katmanı: Veri modellerini içerir.<br>
Data Katmanı: Repository ve Generic Repository yapısıyla veri işlemlerini yönettim.<br>

Business Katmanı: Servis ve manager yapıları ile iş kurallarını belirledim.<br>

🔧 Business & Fluent Validation<br>
Business service sınıflarıyla işlemleri yönettim. FluentValidation kütüphanesi ile kullanıcıdan gelen veriler üzerinde doğrulamalar yaptım.<br>

🎨 UI (Kullanıcı Arayüzü) Katmanı<br>
Layout ve Partial View yapılarıyla sayfaları dinamikleştirdim.<br>

Bootstrap ve Font Awesome ikonlar kullanarak görsel iyileştirmeler yaptım.<br>

DropDown List kullanarak kullanıcıların meslek seçimini sağladım.<br>

🔗 İlişkiler & Job Tablosu<br>
Job tablosunu oluşturdum ve diğer tablolarla ilişkilendirdim. Include metodunu kullanarak ilişkili verileri çektim. Meslek seçimi için dropdown listeleri ve güncelleme işlemlerini tamamladım.<br>

🔐 Identity Giriş/Kayıt Sistemi<br>
ASP.NET Identity kütüphanesini projeye entegre ettim.<br>

AppUser sınıfı ile kullanıcı modelini oluşturdum.<br>

Kullanıcı kayıt, giriş, çıkış ve profil bilgileri düzenleme işlemlerini gerçekleştirdim.<br>

Error Identity Describer sınıfı ile hata mesajlarını özelleştirdim.<br>

🛠️ Genel Teknikler<br>
ASP.NET Core MVC<br>

Entity Framework Core (Code First)<br>

N Katmanlı Mimari<br>

Repository & Generic Repository Pattern<br>

Fluent Validation<br>

Identity Kullanıcı Yönetimi<br>

Bootstrap / Razor View / Partial View<br>

