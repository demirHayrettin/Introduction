//Matematik metotlarının bulunduğu Math kütüphnasi içerisinde gerekli metotları kullanarak matematiksel işlemleri kolayca yapabiliriz.

//Math.Abs(-122); // 122 (mutlak değer)

//double sayi = 20.6;

//Console.WriteLine(Math.Round(sayi)); //

///*		Math.Abs(-5)	5	int
//		Math.Abs(5)	5	int
//		Math.Abs(int.MinValue+1)	2147483647	int
//		Math.Round(20.6)	21	double
//		Math.Round(20.4)	20	double
//		Math.Round(20.50)	20	double
//		Math.Round(20.51)	21	double
//		Math.Round(20.49)	20	double
//		Math.Round(20.51,1)	20.5	double
//		Math.Round(20.5122,3)	20.512	double
//		Math.Round(20.5122,2)	20.51	double
//		Math.Round(20.51,1)	20.5	double
//		Math.PI	3.1415926535897931	double
//		Math.Ceiling(46544.54m)	46545	decimal
//		Math.Floor(46544.54m)	46544	decimal
//		Math.Exp(Math.E)	15.154262241479262	double
//*/

//Kullanıcı tarafından girilen bir sayının kullanıcı tarafından girilen kuvvetini alıp ekrana yazınız
//Console.WriteLine("Kuvetini almak istediğiniz sayıyı giriniz");

//int sayi = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Sayının kuvvetini giriniz");

//int kuvveti = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Sonuc: " + Math.Pow(sayi, kuvveti));

//Örnek 2: Kullanıcı tarafından girilen double türünden kilo değerini tamsayıya yuvarlayan programı yazınız.
//Console.WriteLine("Kilo miktarını giriniz");
//double sayi = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Tam sayı değeri: " + Math.Round(sayi));

//Örnek 3:  Kullanıcı tarafından girilen tüm ondalıklı sayıları aşağı yuvarlayan programı yazınız.

//Console.WriteLine("Bir sayı giriniz");
//double sayi = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Tam sayı değeri: " + Math.Floor(sayi));

//Örnek 4: Kullanıcı tarafından girilen tüm ondalıklı sayıları yukarı yuvarlayan programı yazınız.
//Console.WriteLine("Bir sayı giriniz");
//double sayi = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Tam sayı değeri: " + Math.Ceiling(sayi));

//ÖRnek 1: Ekrana sistemin anlık zaman ve saat bilgisini gg.aa.yyyy ss:dd formatında yazan program.

//DateTime anlıkzaman = DateTime.Now;

//Console.WriteLine("Şu an: " + anlıkzaman);

//ÖRnek 2: Ekrana sistemin anlık zaman ve saat bilgisini gg.aa.yyyy gün formatında yazan program.


//DateTime anlıkzaman = DateTime.Now;

//Console.WriteLine("Şu an: " + anlıkzaman.ToLongDateString());

//ÖRnek 3: Kullanıcıdan alınan doğum tarihi bilgisi ile kullanıcının yaşını hesaplayan program

//Console.WriteLine("Lütfen doğum tarihinizi ggg.aaa.yyy olarak giriniz.");

//Console.Write("Doğum Tarihiniz: ");
//String girilenTarih = (Console.ReadLine());

//string[] diziTarih = girilenTarih.Split(".");

//int gün = Convert.ToInt32(diziTarih[0]);
//int ay = Convert.ToInt32(diziTarih[1]);
//int yıl = Convert.ToInt32(diziTarih[2]);

//DateTime dogumTarihi = new DateTime(yıl, ay, gün);

//Console.WriteLine("Yaşınız : " + DateTime.Now.Subtract(dogumTarihi).Days / 365);

//// ÖRnek 4: Girilen iki tarih arasındaki gün farkını  bulan programı yazınız. 
//// Timespan kullanın,
///
//Console.WriteLine("Lütfen 1. Tarihi Giriniz.");

//String girilenTarih1 = (Console.ReadLine());
//string[] tarih1 = girilenTarih1.Split(".");

//int gün1 = Convert.ToInt32(tarih1[0]);
//int ay1 = Convert.ToInt32(tarih1[1]);
//int yıl1 = Convert.ToInt32(tarih1[2]);

//DateTime tarih1G = new DateTime(yıl1, ay1, gün1);

//Console.WriteLine("Lütfen 2. Tarihi Giriniz.");

//String girilenTarih2 = (Console.ReadLine());
//string[] tarih2 = girilenTarih2.Split(".");

//int gün2 = Convert.ToInt32(tarih2[0]);
//int ay2 = Convert.ToInt32(tarih2[1]);
//int yıl2 = Convert.ToInt32(tarih2[2]);

//DateTime tarih2G = new DateTime(yıl2, ay2, gün2);

//TimeSpan farkGun = tarih2G.Subtract(tarih1G);

//Console.WriteLine("Gün Farkı : " + farkGun.Days);

//ÖRnek 5: Ekrana aşağıdaki vereceğim formatlarda çıktı alınız.
///* 03.06.2022
//* Haziran 2022
//* 3 Haziran   
//* 
//* dd gün sayısını döndürür => 3
//* ddd Kısa Gün Adını Döndürür => Cum
//* dddd Gün adını döndürür =>Cuma
//* MM ay sayısını döndürür =>6
//* MMM ksıa ay adını döndürür => Haz
//* MMMM ay adını döndürür =>Haziran
//* yy kısa yıl sayısını döndürür => 22
//* yyy yıl sayısını döndürür => 2022
//*/

DateTime tarih = new DateTime(2022, 06, 03);
Console.WriteLine(tarih.ToShortDateString());
Console.WriteLine(tarih.ToString("MMMM" + "yyy"));
Console.WriteLine(tarih.ToString("MM" + "MMMM"));

