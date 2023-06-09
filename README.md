# InternetCafe-SureUzatim-Siparis-Uygulamasi

Bu C# dilindeki internet cafe uygulaması, müşterilerin internet cafe işletmecisiyle iletişim kurmasını kolaylaştıran bir uygulamadır. Uygulama, müşterilerin masalarını açtıktan sonra süre uzatma taleplerini iletmelerine, içecek/içecek siparişlerini verip işletmeciye iletmelerine ve istedikleri oyun CD'lerini satın almalarına olanak tanır.
# Uygulama, aşağıdaki temel özellikleri içerir:
# Müşteri Masa Bilgisi:

Müşterilerin masalarını temsil eden bir BUTON bulunmaktadır Bu Buton Ana sayfa görevi görür.
Her müşteri, Masasını, Süre talebini, Yemek Ve İçecek siparişlerini ve satın almak istediği oyun CD'lerine Ulaşabilceği Otomasyon Uygulamasına sahiptir.
![video1](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/1a164114-01d9-4ce4-9915-5851dfcb8a31)

# Yemek ve İçecek Siparişi:

Müşteriler, Ymek Ve İçecekler Butonuna basarak İstedikleri yemek ve içeceği seçerek Yemek/içecek siparişi verebilir.
Bu yöntem, müşterinin siparişini alır ve işletmeciye iletir. </br>
*İşletmeci, müşterinin siparişini alır ve hazırlar. </br>
*Daha sonrada Müşterinin Masasına teslim eder  </br>
*Müşteriler Yemek yerken irternette vakit geçirebilirler. </br>
![video2](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/3be6cc02-4a46-4735-bcd2-5a190bc31076)

# Oyun CD'si Satın Alma:

*Müşteriler, Oyun Butonuna tıklayarak istedikleri oyun CD'lerini satın alabilir. </br>
*Bu yöntem, müşterinin oyun CD'si satın alma talebini işletmeciye iletir. </br>
*İşletmeci, müşterinin talebini alır ve müşteriye oyun CD'sini sağlar. </br>
*Bu sayede müşteriler istedikleri oyunu cafede daha indirimli bir fiyata satın alabilirler. </br>
![video3](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/a2bc72fb-9051-4893-a820-11107509d9b2)

# Süre Uzatma Talebi:

*Müşteriler, sürelerini uzatmak istediklerinde Süre talebi butonuna tıklayıp SÜre talep edebilirler. </br>
*Bu yöntem, müşterinin kalan süresine belirli bir süre ekler veya bitmiş olan sürelerine ek süre ekler ve bu talebi işletmeciye iletir. </br>
*İşletmeci, müşterinin süresini uzatır ve süre uzatmanın başarılı olduğunu onaylar. </br>
![video4](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/1477a84e-25cb-421d-be2b-428349eb64ec)

# YAPIM AŞAMALARI #

# 1-Aşama  (Tasarımlar)
*Visual Studio Code'da yeni bir proje açın ve Windows Form Uygulaması (.NET Framework) seçin ve projeyi açın. </br>
*Bu sayfa çıkıcaktır. şimdi özelliklere girip Start positionu (Center Screen) yapın  </br>
*Ekranımız tam ekran olmasın diye maximize Box seçenegini false yapın </br>
*Ben formBorderStayle seçeniğini none yaptım  siz yapmayabilirsiniz tabi </br>


![foto1](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/c5fc18e6-47d5-48fe-8c2d-48e7bd655b55)

Daha sonra araç kutusundan </br>
* Panel (Arka plan olarak kullandım)
* Button (Menü seçeneklerinde(Masa-1, Yemek Ve içecekler, Oyun, Süre talebi), Hesapla Ve Sipariş Ver butonları olarak kullandım)</br>
* PictureBox (Resim eklemek için kullandım)</br>
* Label (Yazı eklemek için kullandım)</br>
* CheckBox (Vermiş olduğum seçenekleri seçerek işaretlemek için kullandım)</br>
* NumericUpDown (Seçmiş olduğum seçeneklerin kaç adet seçiceğimi işaretlemek için kullandım ve hesaplamak için)</br>
* TextBox (Toplam tutarı yazdırmak için kullandım)</br>
* İlk sayfa tasarımım bu şekilde siz daha farklı şekilde araç butonundan üstteki özellikleri sürükleyip kullanabilirsiniz ve özellikler kısmından seçenekleri değiştirebilirsiniz.
![foto2](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/27987866-5f88-40b8-b9da-c5cadfe170ab)
</br>
*İkinci sayfayı Yukarıdaki Project seçeneğine tıklayıp add user control (Windoes form)'a tıklarsanız oluşturabilirsiniz.








