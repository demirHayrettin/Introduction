
int sayi; // integer veri tipinde sayi isimli bir değişken tanımladım

Console.WriteLine("Lütfen Karesini Almak İstediğiniz Tamsayıyı Giriniz"); // output
                                                                                 
string donenDeger = Console.ReadLine(); // Kullanıcıdan bir string değer istiyorum (ya da null gelebilir ama bunu sonra konuşacağı.)
// Console bir class (sınıf) tır.
// ReadLine bir methot'tur.
// ReadLine bir parametre almayan methottur.
// ReadLine geriye string tipinde değer döndüren mettotur.

sayi = Convert.ToInt32(donenDeger);
// Convert is a Class
// ToInt32 is a method
// ToInt32 geriye integer döndüren method.

// int karesi = sayi * sayi;

// int karesi = Convert.ToInt32(Math.Pow(sayi, 2));

int karesi = (int)Math.Pow(sayi, 2);

Console.WriteLine(sayi +" sayısnın karesi:  " + karesi);

