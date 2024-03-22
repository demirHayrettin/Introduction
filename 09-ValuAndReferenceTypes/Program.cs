
// Value Types: 
// Value Types veri türleri RAM'in STACK bölümünde barındırılır.
// Value Types veri türleri içerisinde verilen değerin kendisi tutulur
// *** Value Types veri türlerinde değişkenler arası kopyalama işlemi yapıldığında verinin kendisi kopyalanır.***

// Value Types veri türlerinden bazıları:
// bytei sbyte, short, ushort, int, uint, long, ulong, loat, double, decimal, char, bool gibi türler RAM'in STACK bölümünde saklanır.


// Reference Types:
// Başvuru (Reference) Türleri değişkenleri başvuruları kendi verilerine (nesneler) depolar. RAM'in HEAP alanında değerler tutulur. Bu türdeki verielere erişmek için, STACK bölümnde tutulan adresler kullanılır. Yani, HEAP'te tutulan verinin adresi STACK'te tutulur. Bu sebebl, STACK'te birden fazla değişkende aynı HEAP alanının adresi tutulabilir. Dolayısıyla, HEAP'teki verinin içerisinde yapılan değişikler başvuran iki değişkeni de etkilemiş olabilir.

// Reference Types türlerin bazıları:
// string, class, array

using System.Diagnostics.Contracts;

string metinsel1 = "Bilge Adam";

string metinsel2;

metinsel2 = metinsel1;

Console.WriteLine(metinsel1);
Console.WriteLine(metinsel2);

Console.WriteLine(metinsel1.GetHashCode());
Console.WriteLine(metinsel2.GetHashCode());

// int sayi = 5;

Console.WriteLine(new string('*', 30));

metinsel2 = "Bilge Kadın";

Console.WriteLine(metinsel1);
Console.WriteLine(metinsel2);

Console.WriteLine(metinsel1.GetHashCode());
Console.WriteLine(metinsel2.GetHashCode());


Console.WriteLine(new string('*', 30));

// new Random();// Random class ından bir nesne (örnek, instance) oluşturuyorum.

Random rnd = new Random(); // Random veri tipinddeki, rnd ismindeki bir değişkende tutuyorum.
rnd.Next(0, 100); 

Kisi ali = new Kisi();
ali.yas = 18;


Kisi veli = new Kisi();
veli.yas = 25;

Kisi ayse = new Kisi();
ayse.yas = 26;
ayse.ad = "Ayşe";
ayse.soyad = "Demir";

ali = veli; // ali ve veli nin adresleri birbirine aynı oldu.
ali.yas = 45;

Console.WriteLine("Ali'nin yaşı: " + ali.yas);
Console.WriteLine("Veli'nin yaşı: " + veli.yas);
Console.WriteLine("Ayşe'nin yaşı: " + ayse.yas);

Console.WriteLine(ali.GetHashCode());
Console.WriteLine(veli.GetHashCode());
Console.WriteLine(ayse.GetHashCode());


// ***BURADAKİ HER ŞEY MÜLAKATDA KESİM ÇIKAR****
public class Kisi
{
    // sınıf üyeleri : fields (yas), properties, methods, const (pi, e)
    public int yas;
    public string ad;
    public string soyad;

}


