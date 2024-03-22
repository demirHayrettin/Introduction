// Instance Alma (Örnek Alan)

// New Random(); Random sınınfının bir örneği alınarak bir nesne oluşturulur.

using _40_SınıfKavrami;

// Personel sınıfından bir nesne (örnek) oluşturdum.

Personel calısanHayrettin = new Personel(); // Personel veri tipindeki calısanHayrettin değişkeni Personel nesnesini tutuyor.

calısanHayrettin.Ad = "Hayrettin";
calısanHayrettin.Soyad = "Demir";
calısanHayrettin.Yas = 27;
calısanHayrettin.Unvan = "Proje Koordinatörü";
calısanHayrettin.TabanMaas = 17002;
calısanHayrettin.CocukSayisi = 0;

Console.WriteLine("Personel Bilgieleri");

Console.WriteLine($"Adı: {calısanHayrettin.Ad}\nSoyad: {calısanHayrettin.Soyad}\nYaşı: {calısanHayrettin.Yas}\nMaaşı: {calısanHayrettin.TabanMaas} ");

Personel calısanBilge = new Personel();

calısanBilge.Ad = "Bilge";
calısanBilge.Soyad = "Demir";
calısanBilge.Unvan = "Bakıcı";
calısanBilge.CocukSayisi = 2;
calısanBilge.Yas = 32;
calısanBilge.TabanMaas = 50000;

Console.WriteLine("Personel Bilgieleri");

//Console.WriteLine($"Adı: {calısanBilge.Ad}\nSoyad: {calısanBilge.Soyad}\nYaşı: {calısanBilge.Yas}\nMaaşı: {calısanBilge.TabanMaas} ");
calısanBilge.PersonelBilgileriniYaz();

//calısanBilge.Maas = 150000;
//calısanBilge.MaasHesapla();
