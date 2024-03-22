//Bir tam sayı iste karesi ve küpü hesapla ekrana yazdır
//" ", özellikle yazdırmak istediğimiz zaman kullanılır

//1. Adım: Başla
//2. Adım: Kullanıcıdan bir tam sayı iste (sayi)
//3. Adım: Hesapla(sayiKaresi = (sayi * sayi))
//4.Adım: Hesapla(sayiKüpü = (sayi * sayi * sayi))
//5.Adım: Ekrana Yaz(sayiKaresi, sayiKüpü)
//6.Adım: Bitir.

using System.Numerics;

int gelenSayi;
Console.WriteLine("Lütfen karesinini ve küpünü hesaplamak istediğiniz sayıyı giriniz: ");

string gelenSayiString = Console.ReadLine();

gelenSayi = int.Parse(gelenSayiString);

//int karesi = gelenSayi * gelenSayi;
//int karesi = (int)Math.Pow(gelenSayi, 2);
//int kupu = karesi * gelenSayi;

BigInteger karesiBigInteger = BigInteger.Parse(gelenSayiString) * BigInteger.Parse(gelenSayiString);
BigInteger kupuBigInteger = BigInteger.Parse(gelenSayiString) * BigInteger.Parse(gelenSayiString) * BigInteger.Parse(gelenSayiString);

Console.WriteLine(karesiBigInteger);
Console.WriteLine(kupuBigInteger);



//Console.WriteLine("Sayının karesi: " + gelenSayi * gelenSayi);
//Console.WriteLine("Sayının küpü: " + gelenSayi * gelenSayi * gelenSayi);


int x = int.MaxValue;

long LongSayi = x;

//int y = LongSayi; Hata verir büyük boyutlu bir değeri küçük boyutlu atayamazsın

//short kisaSayi = x; Hata verir

//y = kisaSayi;