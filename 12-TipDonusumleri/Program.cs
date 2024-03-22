// Tip Dönüşümleri

// Bir veri tipindeki değişkenin değeri, farklı veri tipindeki değişkene çevirmek için ihtiyacımız olan işleme tip dönüştürme işlemi denir..NET Core tarafında, Convert sınıfı ya da parse() metodu ve Casting işlemi bulunur. Ayrıca bu ToStirng() metodu ile de tip dönüştürme işlemi yapabiliriz.


using System.Diagnostics.Metrics;

int sayi = 1023;

// byte donusturulenSay = Convert.ToByte(sayi); // Overflow Exception

// byte donusturulenSayi = byte.Parse(sayi.ToString());  // Overflow Exception

// byte donusturulenSayi = (byte)sayi; // Casting işlemi yapıyorum. Tekrardan dönüyormuş gibi, modunu alıyor (%) 


//byte donusturulenSayi = byte.Parse(sayi.ToString());  


// byte donusturulenSayi = (byte)sayi; // (byte) ile sayi nin byte olarak geleceğini garanti ediyorum.

byte sayi2 = 255;

sayi = sayi2; // Kapalı dönüşüm yapmış oldum.

Console.WriteLine(sayi);

bool dogruMu = true; //boolean veri tipi true ya da false değer alır.

// byte donusturulenByte =dogruMu; // hatalı 

byte donusturulmusBoolDeger = Convert.ToByte(dogruMu);
sbyte donusturulmusBoolDeger2 = Convert.ToSByte(dogruMu);
int donusturulmusBoolDeger3 = Convert.ToInt32(dogruMu);

Console.WriteLine(donusturulmusBoolDeger);

Console.WriteLine(new string ('*',30)); 
byte dogruMu2 = 1;
decimal dogruMu3 = 0.5m;
int dogruMu4 = 0;
int dogruMu5 = -1;


bool booleanDeger2 = Convert.ToBoolean(dogruMu2);
bool booleanDeger3 = Convert.ToBoolean(dogruMu3);
bool booleanDeger4 = Convert.ToBoolean(dogruMu4);
bool booleanDeger5 = Convert.ToBoolean(dogruMu5); // Boolean a donustururken0 değeri için false geri kalan tüm değerler için true değerini atar.


Console.WriteLine(booleanDeger2);
Console.WriteLine(booleanDeger3);
Console.WriteLine(booleanDeger4);
Console.WriteLine(booleanDeger4);

int sayiDegeri = 20;

Console.WriteLine(sayiDegeri); // int parametresi alıyor kendisi içerisinde otomatik stringe çevirip ekrana yazdırıyor.
Console.WriteLine(sayiDegeri.ToString()); // Burada Writeline metodu Tostring parameteresi alıyor.Stringe çevirip yazıyor.


Console.WriteLine(new string('*', 30));

string girilenDeger = "Bige Adam Akademi ";
string girilenDeger2 = "Boost Yıldız Yazılımcı Yetiştirme Programı";

string toplam = girilenDeger + girilenDeger2; // iki string değeri birleştirip ekrana yazdırıyorum.


Console.WriteLine(toplam);

Console.WriteLine(string.Concat(girilenDeger, girilenDeger2)); // iki string değeri birleştirip ekrana yazdırıyorum.

// TODO: Boxing ve Unboxing kavramlarını araştırınız. Bir console örneği yapınız.

//Değer tipleriin referans tipine dönüşmesine kutulam (boxing), referans tipinin değer tipine dönüşmesine ise(unboxing) denir.


int n = 156;

object obj = n; // boxing işlemi yani değer (int) tipli değişkeni referans tipli değişkene dönüştürdük.

n = 456;

Console.WriteLine("Değer tip değeri: "+n);
Console.WriteLine("Referans tip değeri: "+obj);

Console.WriteLine(new string('*', 30));

Int32 x = 123;
Int64 y;
object obj2 = x;
y = (Int32)obj2;  // hata verir // Unboxing işlemi yani kutudan çıkarma işlemi referans tipli bir değişkeni değer tipli bir değişkene dönüştürme işlemi yaptık.
Console.WriteLine("y = " + y);

int a = 123;
object obj3 = a;
a = (int)obj3;

