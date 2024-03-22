/* Tam biletin fiyatı 80 TL, öğrenci biletinin fiyatı 60 TL olan bir sinema salonuna giden ailelerin
ödemesi gereken toplam ücreti bulan programı yazınız. 
(Bilet fiyatları sabit olarak girilecektir.)
(Programı yazarken test için 3 çocuklu(öğrenci) bir ailenin(anne - baba ve 3 çocuk) 41 TL çıkması gerekiyor)
*/

int toplam, ob = 130, tb = 160;

Console.WriteLine(" Kaç kişi öğrenci? ");

int ogrenciBilet = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(" Kaç kişi tam bilet? ");

int tamBilet = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Toplam ödemeniz gereken tutar: " + (ob*ogrenciBilet +tb*tamBilet) + " TL ");
