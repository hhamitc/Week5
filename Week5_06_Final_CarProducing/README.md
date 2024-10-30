# Patika+ Back-End Web Geliştirme Eğitimi - 5. Hafta Kapanış Ödevi

## Proje: Araba Fabrikası Üretim Uygulaması

### Proje Amacı
Bu uygulama, kullanıcıdan alınan bilgilerle bir araba fabrikasında araba üretiyormuş gibi davranan basit bir konsol uygulamasıdır. Her üretilen araba için belirli bilgileri kullanıcıdan alır, özelliklerini listeler ve kullanıcıya yeni bir araba üretmek isteyip istemediğini sorar. Amaç, kullanıcı girdilerini işleyerek birden fazla araba kaydını listelemektir.

---

### İstenilen Gereksinimler

**Hafta 5 - Kapanış**
Araba fabrikasında araba ürettiğimizi varsayarak bir konsol uygulaması geliştirelim.

- **Araba Class'ı**  
  - `Üretim Tarihi`, `Seri Numarası`, `Marka`, `Model`, `Renk`, `Kapı Sayısı` gibi özelliklere sahip bir `Araba` sınıfı tanımlayın.

---

### Program Akışı

1. **Kullanıcıdan Araba Üretme İzni İsteme**  
   Konsol ekranında kullanıcıya, yeni bir araba üretmek isteyip istemediği sorulacak. Eğer üretmek istiyorsa **`e`**, istemiyorsa **`h`** harfi ile yanıt vermesi istenecek.  
   - **Büyük-küçük harf duyarlılığı** ortadan kaldırılmalı.
   - Geçersiz bir cevap verildiğinde, bu durum kullanıcıya bildirilecek ve aynı soru tekrar sorulacaktır.

2. **Kullanıcı Hayır Cevabı Verirse Programı Sonlandırma**  
   Kullanıcı, `hayır` cevabını verirse program sonlandırılacak. Eğer `evet` cevabını verirse, bir araba nesnesi oluşturulacak ve bu nesnenin özellikleri konsol ekranından kullanıcıya girdirilecek.

3. **Otomatik Üretim Tarihi Atama**  
   Üretim Tarihi, araba üretildiğinde otomatik olarak atanacak ve o anki tarih kullanılacak.

4. **Kapı Sayısı İçin Hatalı Giriş Kontrolü**  
   `Kapı Sayısı` için sayısal olmayan bir değer girilmeye çalışılırsa, program hata fırlatmasını engelleyecek, uyarı mesajı verecek ve kullanıcıyı aynı satıra yönlendirecektir.  
   - Bu işlem için `goto` komutunun araştırılması ve kullanılması beklenmektedir.

5. **Araba Nesnesini Listeye Ekleme**  
   Her üretilen araba nesnesi `arabalar` adlı bir listeye eklenmelidir.

6. **Tekrar Araba Üretmek İsteyen Kullanıcılar İçin Döngü**  
   Kullanıcıya başka bir araba üretmek isteyip istemediği sorulacaktır. `Evet` cevabını verirse program, akışta 2. aşamaya geri dönerek yeni bir araba üretip listeye eklemelidir.  
   `Hayır` cevabını verirse, `arabalar` listesindeki tüm arabaların seri numarası ve marka bilgileri ekrana yazdırılmalıdır.

---

### Teknik Detaylar

- **Kullanılacak Sınıf:** `Araba`
  - Özellikler:
    - `SerialNumber` (Seri Numarası)
    - `Brand` (Marka)
    - `Model`
    - `Color` (Renk)
    - `DoorCount` (Kapı Sayısı)
    - `ProduceDate` (Üretim Tarihi - Otomatik atanacak)

