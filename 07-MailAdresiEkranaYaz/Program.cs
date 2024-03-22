// Kullanıcıdan ad ve soyad alıp  " ad.soyad@gmail.com " şeklinde ekrana yazdıran algoritma.
// 1.A: ad, soyad, mail tanımla
// 2.A: Ekrana Yaz "Adınız: "
// 3.A: Ad gir
// 4.A: Ekrana Yaz "Soyadınız: "
// 5.A: Soyad gir
// 6.A: Ekrana Yaz " Ad.Soyad@gmail.com"

// ToLower harfleri küçültür ToUpper harfleri büyültür.
// Trim boşlukları siler hem başından hem sonundan

String Ad, Soyad, Mail;

Console.WriteLine("Adınız: ");
Ad = Console.ReadLine();

Console.WriteLine("Soyadınız: ");
Soyad = Console.ReadLine();

Console.WriteLine(" Mail adresiniz: " + Ad.ToLower().Trim()+ "." + Soyad.ToLower().Trim() + "@gmail.com");




