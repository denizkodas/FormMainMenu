# Kargo Takip Projesi

Kargo Takip Projesi, kargo hareketlerinin ve durumlarının yönetilmesini sağlayan, katmanlı mimariyle geliştirilmiş bir Windows Forms uygulamasıdır. Proje, kargo taşıma süreçlerini izlemek, güncellemek ve raporlamak için temel işlevler sunar.

## İçerik

- [Genel Bakış](#genel-bakış)
- [Katmanlar](#katmanlar)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Temel Sınıflar ve İşlevler](#temel-sınıflar-ve-işlevler)
- [Ekran Görüntüleri](#ekran-görüntüleri)
- [Katkı Sağlama](#katkı-sağlama)
- [Lisans](#lisans)

---

## Genel Bakış

Bu proje, kargo hareketlerinin (taşıyıcı, şube, tarih, hareket tipi vb.) ve kargo durumlarının (lokasyon, açıklama, güncelleme tarihi vb.) takibini sağlar. Kullanıcı dostu bir arayüz ile kargo işlemlerini kolayca yönetebilirsiniz.

## Katmanlar

- **EntityLayer**: Veri nesneleri ve modelleri içerir.
- **DataAccessLayer**: Veritabanı işlemlerini (CRUD) gerçekleştirir.
- **BussinesLayer**: İş kurallarını ve doğrulamaları içerir.
- **KargoTakipProjesi**: Windows Forms arayüzünü barındırır.

## Kullanılan Teknolojiler

- C# 7.3
- .NET Framework 4.7.2
- Windows Forms
- SQL Server (ADO.NET ile bağlantı)
- Katmanlı mimari

## Kurulum

1. **Projeyi klonlayın:**
2. **Visual Studio 2022 ile açın.**
3. **Gerekli NuGet paketlerini yükleyin.**
4. **Veritabanı bağlantı ayarlarını `Baglanti.bgl` üzerinden yapılandırın.**
5. **Projeyi derleyin ve çalıştırın.**

## Kullanım

- Kargo hareketi ekleyin, güncelleyin veya silin.
- Kargo durumlarını ve hareket geçmişini görüntüleyin.
- Raporlama ve bildirim özelliklerini kullanın.

## Temel Sınıflar ve İşlevler

### EntityLayer

- `EntityKargoHareket`: Kargo hareketi bilgilerini tutar.
- `EntityKargoDurum`: Kargonun mevcut durumu ve lokasyonunu tutar.

### DataAccessLayer

- `DalKargoHareket`: Kargo hareketleri için CRUD işlemleri sağlar.
- `KargoHareketEkle`
- `KargoHareketSil`
- `KargoHareketGuncelle`
- `KargoHareketListele`

### BussinesLayer

- `BLKargoHareket`: İş kuralları ve doğrulama içerir.
- `BLKargoHareketEkle`
- `BLKargoHareketGuncelle`
- `BLHareketSil`
- `KargoHareketListele`

### KargoTakipProjesi

- `FormMainMenu`: Ana menü ve kullanıcı arayüzü.
- Farklı formlar üzerinden ürün, sipariş, müşteri, raporlama ve bildirim işlemleri yapılabilir.

## Ekran Görüntüleri

> Ekran görüntüleri ekleyebilirsiniz.

## Katkı Sağlama

Katkı sağlamak için lütfen bir pull request gönderin veya issue açın.

## Lisans

Bu proje MIT lisansı ile lisanslanmıştır.
