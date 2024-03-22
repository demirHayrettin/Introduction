// Ternary if :
// Tek satırda, ufak mekanizma ile yolumuza devam etmek istiyorsak, soru işareti (?) operatörü ile bize bu pratikliği sağlar.

// Kullanım:
// kontrolEdilecekDeger (KarsilastirmaOperatoru) karsilastirilan deger ? Durumun doğru olması durumunda : 

//int x = 5;

//if (x >= 5)
//    Console.WriteLine("X 5ten büyüktür ya da eşittir.");
//else
//    Console.WriteLine("X 5 ten küçüktür");

//string yazi = (x >= 5) ? "X 5 ten büyüktür ya da eşittir" : "x 5 ten küçüktür.";

//Console.WriteLine(yazi);



// Örnek:

//Console.WriteLine("Lütfen bir isim yazınız.");

//string isim = Console.ReadLine();


//Console.WriteLine((isim == "Bilge Adam") ? "Doğru yazdınız" : "Yanlış Yazdınız");

//Örnek2:

//int sayi1 = 1, sayi2 =10;

//Console.WriteLine((sayi1 > sayi2) ? sayi1: (sayi1 == sayi2) ? "Sayılar eşit" : sayi2);

//Örnek3

Console.WriteLine("Bir sayı giriniz");

int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir sayı daha giriniz");

int sayi2 = Convert.ToInt32(Console.ReadLine());


bool karsilastirma = (sayi1 > sayi2); // ? true:false;
Console.WriteLine(karsilastirma ? "Sayı 1 > Sayı2" : "Sayı2 > Sayı1"); 



