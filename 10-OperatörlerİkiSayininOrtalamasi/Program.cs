#region MyRegion
//1.Adım: Başla
//2. Adım: Kullanıcadan sayi1 ve sayi2 al
//3. Adım: Hesapla(ortalama = (sayi1 + sayi2) / 2)
//4.Adım: Ekrana Yaz(ortalama)
//5.Adım: Bitir

// ctrl + K + C seçili tüm satırları yorum satırına çevirir
/// ctrl + K + U seçili tüm satırları yorum satırından kaldırır  
// */ birden fazla satır yorumu eklemek istersek kullanırız

#endregion
#region MyRegion
int sayi1, sayi2; // iki tane integer veri tipinde değişken oluşturdum.

Console.WriteLine("Lütfen ortalamasını almak istediğiniz 1. sayıyı giriniz: "); //output

sayi1 = Convert.ToInt32(Console.ReadLine()); // yukarıda tanımladığım değişkene bir değer girmesini istedim ve girilen string değeri integer a çevirmesini istedim.
Console.WriteLine("Lütfen ortalamasını almak istediğiniz 2. sayıyı giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

double ortalama = (sayi1 + sayi2) / 2.0;
Console.WriteLine("Girdiğiniz sayıların aritmetik ortalaması: {0}", ortalama);
//Console.WriteLine("Girdiğiniz sayıların aritmetik ortalaması: " + ortalama);
	#endregion