// Diziler - Arrays : Aynı tipteki verileri bir arada tutmamızı sağlayan nesnelerdir.
// Dizi tanımlaması : 
// VeriTipi[] diziDegiskenAdi = {Değer1, Değer2 Değer3, ... }; // Eleman Sayısını belirlemeden dizi tanımlaması ve deer atma.
//// VeriTipi[] diziDegiskenAdi = new VeriTipi [DizideOLacakElemaSayisi] {Değer1, Değer2 Değer3, ... }; // Eleman Sayısı baştan belli olacak şekilde tanımlama ve değer atama yaptık.

//string[] students = new string[3] { "Bilge", " Adam ", "Akademi" }; // Dizi boyutundan az ya da çok girilirse ilgili sayı kadar eleman beklediğini belirten hata verir.

//students = new string[4] { "", "", "", "" };

//string[] students2 = { "Bilge", "Adam", "Akademi", "Boost", "Yıldız", "Yazımlımcı", "Yetiştirme", "Programı", "HS-15", "Grubu" }; // Eleman sayısı baştan belirlenmemiş dizi.

//string[] students3 = new string[0]; // Eleman sayısı 0 olan bir dizi tanımlama

//// Dizi içerisindeki index numarası bilinen elemanı almak:
//// student2 dizisindeki Yazılımcı kelimesini almak için index numarası 5 olarak girilmelidir.

//Console.WriteLine("Dizinin 5. indexinde bulunan eleman budur: " + students2[5]);

//// NOT: Bir dizideki ilk index numarası 0 dan başlar 
//// bir dizi içindeki tüm elemamanları yazdırabilmek için foreach döngüsü kullanılır.

//foreach (string ogrenci in students2)
//{
//    Console.WriteLine(ogrenci);
//}

//Console.WriteLine(new string('*', 30));

//for (int i = 0; i < students2.Length; i++)
//{
//    Console.WriteLine(students2[i]);
//}

//int sayac = 0;

//Console.WriteLine(new string('*', 30));

//while (sayac < students2.Length)
//{
//    Console.WriteLine(students2[sayac]);
//    sayac++;
//}

//Console.WriteLine(new string('*', 30));

//int counter = 0;

//do
//{
//    Console.WriteLine(students2[counter]);
//    counter++;

//} while (counter < students2.Length);

// yukarıdaki dizieleri yanyana boşluklu bastırma
//Console.WriteLine(new string('*', 30));
//int counter1 = 0;
//do
//{
//    Console.Write(" "+ students2[counter1]);
//    counter1++;

//} while (counter1 < students2.Length);

//string ogrenciler = "";

//foreach (string ogrenci in students2)
//{
//    ogrenciler += ogrenci + " ";
//}
//Console.WriteLine(ogrenciler.Trim());

//// II.Yol

//Console.WriteLine(new string('*', 30));


//for (int i = 0; i < students2.Length; i++)
//{
//    if (i == students2.Length - 1)
//    {
//        Console.Write(students2[i]);
//    }
//    else
//    { Console.Write(students2[i]+" ");
//    }
//}

/* 

1- 25 Elemanlı bir int diztanımlayınız.
2- 5 elemanlı string dizisi tanımlayınız ve içerisine değerler atınız.
3- 2. sorudaki 4. elemanın değerini "Boost" olarak değiştiriniz  
4- 2. sorudaki elemanları ekrana yazdırınız.

*/

//int[] intArray = new int[25];

//for (int i = 0; i < intArray.Length; i++)
//{
//    Random rnd = new Random();
//    intArray[i] = rnd.Next(0, 100);

//}

//foreach (var item in intArray)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(new string('*',30));



//string[] stringArray = new string[5] { "ali", "veli", "mehmet", "hasan", "kaan" };

//stringArray[3] = "Boost";

//foreach (string elemanlar in stringArray)
//{
//    Console.WriteLine("String array elemanları: " + elemanlar);
//}

// 5- Klavyeden kullanıcı tarafından girilen 6 sayıdan en büyüğünü bulan programı dizi kullanarak yazınız.

Console.WriteLine("6 adet sayı giriniz.");

int[] sayilar = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"{i + 1}. Sayıyı giriniz");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
    
}
int maxValue = int.MinValue;
for (int i = 0; i <= sayilar.Length - 1; i++)
{
    if (sayilar[i] > maxValue)
    {
        maxValue = sayilar[i];
    }

}

Console.WriteLine("En büyük sayı : " + maxValue);


//int[] ints = new int[25];

//for (int i = 0; i < ints.Length; i++)
//{
//    Random rnd = new Random();
//    ints[i] = rnd.Next(0, 100);

//}
//int carppimlari = 1;

//foreach (int elemanalar in ints)
//{
//    carppimlari *= elemanalar;
//}

//Console.WriteLine(carppimlari);

int[] programlamaTemelleri = new int[10];

for (int i = 0; i < programlamaTemelleri.Length; i++)
{
    Random rnd = new Random();
    programlamaTemelleri[i] = rnd.Next(0, 100);

}
int notToplamlari = 0;

foreach (var not in programlamaTemelleri)
{
    Console.WriteLine(not);
    notToplamlari += not;
}
Console.WriteLine($"NOTLARIN TOPLAMI: {notToplamlari}\n Ortalması: {notToplamlari / programlamaTemelleri.Length}");