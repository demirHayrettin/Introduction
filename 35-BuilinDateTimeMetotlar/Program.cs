// DateTime metotları bir tarih veya zaman bilgisi ile çalışmak için kullanılır.

//Console.WriteLine(DateTime.Now);

//DateTime.UtcNow { 7.03.2024 17:44:21}
//System.DateTime
//DateTime.Now    { 7.03.2024 20:44:21}
//System.DateTime

//DateTime.TryParse("01.04.2024", out DateTime result3)   true    bool
//result3	{1.04.2024 00:00:00}	System.DateTime


DateTime zaman =  DateTime.Now;

Console.WriteLine("Şu an : "+ zaman);

Console.WriteLine("5 Saat sonrası : " + zaman.AddHours(5));
Console.WriteLine("2 Gün sonrası : " + zaman.AddDays(2));

/*
zaman   { 7.03.2024 20:49:53}
System.DateTime
zaman.AddHours(2)   { 7.03.2024 22:49:53}
System.DateTime
zaman.AddHours(-24) { 6.03.2024 20:49:53}
System.DateTime
zaman.AddDays(-7)   { 29.02.2024 20:49:53}
System.DateTime
zaman.AddMonths(-1) { 7.02.2024 20:49:53}
System.DateTime

zaman.IsDaylightSavingTime()    false   bool
zaman.ToLocalTime()	{7.03.2024 20:49:53}	System.DateTime

zaman.ToLongDateString()    "7 Mart 2024 Perşembe"  string

zaman.ToLongTimeString()    "20:49:53"  string

zaman.ToShortDateString()   "7.03.2024" string

zaman.ToShortTimeString()   "20:49" string
zaman.ToUniversalTime()	{7.03.2024 17:49:53}	System.DateTime
*/


// ÖRnek 3: Kullanıcıdan alınan doğum tarihi bilgisi ile kullanıcının yaşını hesaplayan program

Console.WriteLine("Doğum tarihinizi giriniz. ");

double dogumTarihi = Convert.ToDouble(Console.ReadLine());

