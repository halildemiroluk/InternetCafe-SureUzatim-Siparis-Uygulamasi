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
*İkinci sayfayı Yukarıdaki Project seçeneğine tıklayıp add user control (Windoes form)'a tıklarsanız oluşturabilirsiniz.</br>
*İkinci sayfayıda bu şekilde tasarladım.</br>
*Bu Benim Ana sayfam olucak bu sayfada kod yazmadım.</br>
![foto2 5](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/7a92abb5-228d-41ec-af56-460c194d3e70)
</br>
*şimdi sırada Yemek ve içecekler sayfası var tekrardan yeni bir sayfa açıp üstteki verdiğim araçları kullanarak sayfamı tasarladım.
![foto3](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/6edfce35-f49c-4a86-b6e8-42d5b4a19dc9)
*Sayfa tasarımını yaptıktan sonra sipariş ver butonuna çift tıklayıp şu kodları yazdım. bu kodlar müşteriye geri bildirim olarak mesaj kutusu açar </br>
<code> MessageBox.Show("Siparişiniz alındı masana getiriliyor!!");
</code> 
</br>
*Ürünlerin fiyatını girmek ve toplam hesabı hesaplamak içi hesapla butonuna çift tıkladım. ve şu kodları yazdım </br>
<code>  int a, a2, a3, a4, a5, a6, a7, a8, a9,a10;
            a = Convert.ToInt16(numericUpDown1.Value);
            a2 = Convert.ToInt16(numericUpDown3.Value);
            a3 = Convert.ToInt16(numericUpDown2.Value);
            a4 = Convert.ToInt16(numericUpDown4.Value);
            a5 = Convert.ToInt16(numericUpDown5.Value);
            a6 = Convert.ToInt16(numericUpDown6.Value);
            a7 = Convert.ToInt16(numericUpDown7.Value);
            a8 = Convert.ToInt16(numericUpDown9.Value);
            a9 = Convert.ToInt16(numericUpDown8.Value);
            a10 = Convert.ToInt16(numericUpDown10.Value);
            int c = a * 479 + a2 * 379 + a3 * 32 + a4 * 280 + a5 * 799 + a6 * 111 + a7 * 249 + a8 * 350 + a9 * 44 + a10 * 32;
            textBox1.Text = c.ToString();
</code>
</br> *Bu kod ürünlerin adedini numericupDown dan çeker ve hesaplamak için ise numericUpDown dan çektiğim sayıyı ürünün güncel fiyatı ile çarptım </br>
* Bu sayede toplam hesabı buldum. seçilmeyen ürünler  0 tl ile çarpılıp toplama 0 olarak yansiyacak bu sayede sadece seçilen ürünler hesaplanacak. </br>
* * Kodun mantığı bu.</br>
* * Oyunlar sayfası için yeni bir sayfa oluşturuyorum. ve aynı tasarımı yapıyorum. Hesapla ve sipariş ver butonlarına çift  tıklayıp aynı kodları yazabilirsiniz. </br>

![foto4](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/ee65cfa7-0b52-4e24-a0e9-46cb95599a2a)
</br>

* Son sayfa olan Süre talebi için yeni bir sayfa oluşturun  ve istediğiniz şekilde tasarımını yapın. benim tasarımım bu şekilde.</br>
![foto](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/246669aa-11b7-49f3-915f-c80e3a3297f4)
</br>
*Şimdi ilk butona çift tıklayın ve bu kodu yazın.
<code> MessageBox.Show("Süreniz 15dk uzatıldı!");
</code>
</br>
*Bunu her bir buton için vereceğiniz mesajları değiştirmeyi unutmayın!!.
# Syafa birleştirme
*şimdi ana sayfaya gelin Araç kutusuna tıklayın ve en üste gelin.</br>
buradaki sayfaları teker teker ana sayfaya sürükleyerek sabitleyiniz.</br>
![foto ](https://github.com/halildemiroluk/InternetCafe-SureUzatim-Siparis-Uygulamasi/assets/104024673/ecb74c5f-ce40-4cc8-b043-ecfae0c34c8a)
</br>
*Şimdi Masa-1 Butonuna çift tıklayınız. Ve bu kodları yazınız </br>
<code>  kontrol_11.Show();
            kontrol_31.Hide();
            kontrol_41.Hide();
            kontrol_21.Hide();
            kontrol_11.BringToFront();
</code></br>
</br>
*Bu kod ilk programı çalıştırdığınızda 1. sayfanın önde gözükmesini diğer sayfaların saklanmasını sağlar. bu kodları sayfa sisimlerinize göre değiştiriniz.</br>
*Diğer buttonlar içinde aynısını yapıcağız. </br>
*Yemek ve içecekler butonu için bu kodu: </br>
<code> kontrol_11.Hide();
            kontrol_31.Hide();
            kontrol_41.Hide();
            kontrol_21.Show();
            kontrol_21.BringToFront();
</code></br>
*Oyunlar butonu için bu kodu: </br>
<code> kontrol_31.Show();
            kontrol_11.Hide();
            kontrol_41.Hide();
            kontrol_21.Hide();
            kontrol_31.BringToFront();
</code></br>
*Süre talebi butonu için bu kodu: yazınız. </br>
<code> kontrol_41.Show();
            kontrol_11.Hide();
            kontrol_31.Hide();
            kontrol_21.Hide();
            kontrol_41.BringToFront();
</code></br>
*Uygulama şimdi çalışıcaktır sadece gerekli boyut sorunları oluştuysa onları düzeltiniz.</br>
*Ben resimleri ve ikonları internetten bldum siz istediğiniz yerden alabilirsiniz.


 













