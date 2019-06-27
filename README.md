# Student-Information-System
C# ve SQL Server ile yapmış olduğum öğrenci bilgi sistemi projem.

Projemiz Açıldığında Kullanıc adı ve Şifre giriş ekranıyla bizi karşılamaktadır.

![Giris Sayfası](https://user-images.githubusercontent.com/51914434/60217254-0096f700-9875-11e9-9e43-ace7ba9582e7.jpg)

Kullanıcı adı ve şifre yanış girilirse karşımıza uyarı kutusu çıkar.

![Giris Sayfası2](https://user-images.githubusercontent.com/51914434/60217556-ad717400-9875-11e9-952c-0b3512009a45.jpg)

Ve programımıza giriş yaparız. Menüde Öğrenci , Ders , Not kısımları vardır.

![Ana Form2](https://user-images.githubusercontent.com/51914434/60217607-d5f96e00-9875-11e9-97e3-e445384c2eed.jpg)

Öğrenci ekleme bölümünde öğrenci bilgilerinin eksiksiz doldurulması gereklidir yoksa öğrenci ekleyemeyiz ve bunun için bizi bir hata kutusu karşılar.


![Öğrenci Ekle](https://user-images.githubusercontent.com/51914434/60217618-dbef4f00-9875-11e9-93fa-d1ce64687231.jpg)

Öğrenci Listesi bölümümüzde öğrencilerimizin hepsini görebilir ve yeni eklenen öğrenciler için güncelle butonuna basarak listemizi yenileyebiliriz.

![Öğrenci Listesi](https://user-images.githubusercontent.com/51914434/60217633-df82d600-9875-11e9-8c87-0a44f5e783f9.jpg)

Sectiğimiz öğrencinin herhangi bir bilgisine çift tıklayarak o öğrencinin bilgilerini düzenleyebilir hatta silebilir.

![Öğrenci Sil Düzenle3](https://user-images.githubusercontent.com/51914434/60217665-ec9fc500-9875-11e9-8c23-d83f20a933da.jpg)

Buradan öğrencilerimizin kaç erkek kaç kız olduğunu görebilir ve oranlarını öğrenebiliriz
![Öğrenci Statiği](https://user-images.githubusercontent.com/51914434/60217667-ee698880-9875-11e9-996d-4a047affbdb1.jpg)

Faremiz ile üstüne geldiğimiz bilgilerin arka plan rengini beyaz yaparak bilgiye olan odağımız artar.
![Öğrenci Statiği2](https://user-images.githubusercontent.com/51914434/60217671-ef021f00-9875-11e9-85d2-8cee57b2d028.jpg)

Öğrenci düzenleme ve silme formunu ayrıca buradan tek başına açabilir.
![Öğrenci Sil Düzenle](https://user-images.githubusercontent.com/51914434/60217680-f3c6d300-9875-11e9-92df-edba2921146f.jpg)

ID'sini girdiğimiz öğrenciye ulaşabiliriz.
![Öğrenci Sil Düzenle2](https://user-images.githubusercontent.com/51914434/60217686-f5909680-9875-11e9-93d9-2c7cf03dd3ca.jpg)

Veri Tabanımızda bulunmayan ID girirersek Bulunamadı Hatası alırız.
![Bulunamadı](https://user-images.githubusercontent.com/51914434/60218640-9bdd9b80-9878-11e9-92f9-8f8b427b6bd5.jpg)

Öğrenci Yönetimi Formumuzda Öğrencilerimizi kolaylıkla seçebilir ve seçtiğimiz öğrenciler üzerinde düzenleme yapar ve ya silebiliriz. Aynı zamanda öğrencide ekleyebiliriz.
Search kısmından belirlediğimiz bilgilere ait öğrenciler arasından seçim yapabiliriz.
Örnek olarak isminin içinde M harfi olan öğrenciler.
![Öğrenci Yönet](https://user-images.githubusercontent.com/51914434/60217688-f6c1c380-9875-11e9-872f-10724e4151b6.jpg)

Öğrenci yazdırma formumuzda seçtiğimiz kriterlere uygun olan öğrenci listemizi text dosyası olarak bilgisayarımıza yazdırırız.
![Öğrenci Yazdır](https://user-images.githubusercontent.com/51914434/60217694-f7f2f080-9875-11e9-82c7-d17cbd4b5f5f.jpg)

# DERS
![Main Form Course](https://user-images.githubusercontent.com/51914434/60265368-40e68b80-98ee-11e9-8a7a-c4736573c213.png)

Dersin Adını , Ders saatini ve Bilgilerini girerek Add butonuna basıp ders veri tabanımıza ders ekleyebiliriz.
![Ders Ekle](https://user-images.githubusercontent.com/51914434/60265369-417f2200-98ee-11e9-8655-b132ac4b127d.jpg)

ID'sini girdiğimiz dersi Remove Butonuna basarak veri tabanından silebiliriz.
![Ders Sil](https://user-images.githubusercontent.com/51914434/60265370-417f2200-98ee-11e9-9fc3-63e764afa799.jpg)

Select Course dan var olan dersleri seçerek. Seçtiğimiz desler üzerinde düzenlemeler yapabiliriz.
![Ders Düzenle](https://user-images.githubusercontent.com/51914434/60265371-417f2200-98ee-11e9-95cb-1eb6812de22f.jpg)

Ders listesindeki derslere tıklayarak bilgilerini görebilir istersen düzenleyebilir istersen silebiliriz.
Ve 4 tane olan yön butonları dersler arası geçişimizde bize kolaylık sağlar.
Aynı zamanda yeni ders de ekleyebiliriz.
![Ders Yönet](https://user-images.githubusercontent.com/51914434/60265372-417f2200-98ee-11e9-877e-cfdbf5d201da.jpg)

Derslerimizi bilgileriyle beraber yazdırabiliriz.
![Ders Yazdır](https://user-images.githubusercontent.com/51914434/60265374-4217b880-98ee-11e9-8116-6404a5e96dcd.jpg)

# NOT
![Main Form Not](https://user-images.githubusercontent.com/51914434/60265375-4217b880-98ee-11e9-955d-5c4df56cfac2.jpg)

Listeden seçtiğimiz öğrenciye ,seçtiğimiz desrten not ekleyebiliriz.
Aynı öğrenci aynı dersi birden fazla kez alamaz!
Eğer ki aynı öğrenciye tek dersi birdenf azla kez vermek istersen program bizi hata mesajıyla karşılar.
![Not ekle](https://user-images.githubusercontent.com/51914434/60265376-4217b880-98ee-11e9-8bc9-20d368c81f84.jpg)

Seçtiğimiz bir notu Remove butonuna basarak silebiliriz.
![Not Silme](https://user-images.githubusercontent.com/51914434/60265377-4217b880-98ee-11e9-961c-0fc68e99746b.jpg)

Show Score butonuna basarak Alınan bütün dersleri kim tarafından hangi notlarla alındığının listesini görebiliriz.
Listeden seçtiğimiz not üzerinde , silme işlemi yapabiliriz.
"Average Score By Course" butonuna basarak derslerin not ortalamasını görebiliriz.
![Not Yönetme](https://user-images.githubusercontent.com/51914434/60265378-42b04f00-98ee-11e9-8847-87c144e28d50.jpg)

Show Studen butonuna basarak öğrenci listesine ulaşabilir ve seçtiğimiz öğrenciye Not ekleyebiliriz.
![Not Yönetme2](https://user-images.githubusercontent.com/51914434/60265379-42b04f00-98ee-11e9-9456-59f72d3a0fd8.jpg)

Var olan derslerin not ortalamasını görebiliriz.
![Not Ortalaması](https://user-images.githubusercontent.com/51914434/60265380-42b04f00-98ee-11e9-9143-9c0e8f589c42.jpg)

"Courses List" listesinden seçtiğimiz dersin alındığı öğrenci listesini görebiliriz ve bu listeyi yazdırabilir.
![Not Yazdır](https://user-images.githubusercontent.com/51914434/60265381-4348e580-98ee-11e9-96a5-c416fa28ffea.jpg)

"Student List" listesinden Seçtiğimiz öğrencinin aldığı bütün dersleri ve notlarının listesini görebilir ve bunu liste halinde yazdırabiliriz.
![Not Yazdır2](https://user-images.githubusercontent.com/51914434/60265382-4348e580-98ee-11e9-8c50-1de00378517e.jpg)


## Yapmış olduğum bu projemde veri tabanı kulanımını ve mantığını daha iyi kavramaya çalıştım.
