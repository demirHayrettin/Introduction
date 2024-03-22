// Örnek 8
// Klavyeden girilen fiyatı, KDV(%) ekleyerek KDVli fiyatını ekrana yazan program.

Console.WriteLine("KDV'sini Hesaplamak istediğiniz sayıyı giriniz");

int sayi = Convert.ToInt32(Console.ReadLine());

double kdvliFiyat = (sayi * 1.20);

Console.WriteLine("Girdiğiniz sayının KDV'li değeri: " + kdvliFiyat);

