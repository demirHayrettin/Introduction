//// 0 1 2 3 4 5 6 7 8 9
// B İ L G E   A D A M

// İ harfi kaçıncı indis: 1. index
// İlk A harffi kaçıncı index: 6. İndex
// Son A harffi kaçıncı index: 8. İndex

//string metin = "Bilge adam";
//int boyut = metin.Length; // 10
//int metninsonIndexi = boyut - 1;
////metin = (string)metin.Reverse();

//int sonIndex = metin.LastIndexOf('a');
//int ilkIndex = metin.LastIndexOf('a');


//Console.WriteLine(metin); /*"Bilge Adam"*/
//Console.WriteLine(boyut); // 10
//Console.WriteLine(metninsonIndexi); // 9
//Console.WriteLine(sonIndex); // 8
//Console.WriteLine(ilkIndex); // 6

using System.Security;
using System.Threading;

string metin = "Bilge Adam Boost Yıldız Yazılımcı Geliştirme Programı";



//Console.WriteLine(metin.Length);
//Console.WriteLine("Metnin son idexi: "+ (metin.Length-1));
//Console.WriteLine("son a kaçıncı indexi: "+ (metin.LastIndexOf('a')));
//Console.WriteLine("ilk a kaçıncı indexi: "+ (metin.IndexOf('a')));
//Console.WriteLine("son ' ' kaçıncı indexi: "+ (metin.LastIndexOf(' ')));

// adam 
//bool varMi = metin.Contains("adam");

//metin.EndsWith("mı");
//metin.StartsWith("Bil");
//metin.Contains("Adam", StringComparison.OrdinalIgnoreCase);
//metin.IndexOf   ("ıl");
//metin.LastIndexOf("ıl");
//metin.Insert(19, "Ailesi");
//metin.Remove(15);

string metin2 = metin.Remove(metin.IndexOf("Yıldız "), "Yıldız ".Length);

Console.WriteLine(metin2);

metin.Replace('e', 'i');
metin.Replace("Adam", "İnsan");

// Dizi Değişken Tanımlama 

string[] diziDegisken = new string[3];// 3 Elemanlı string veri tipinde değer tutan bir dizi oluşturduk. diziDegisken isminde ve  bir string[] disisi tipinde değişken tanımladık.

// string deger = new string('*', 30);

string[] elma = { "Bilge", "Adam", "Akademi" }; // Bir string dizisi oluşturduk, süslü parentez içindeki eleman sayısı kadar değer tutan bir dizidir.
Console.WriteLine(new string ('*',30));

string[] parcalanmısMetin = metin.Split(' ');

Console.WriteLine(parcalanmısMetin);

// +parcalanmısMetin[7]// 'parcalanmısMetin[7]' threw an

//foreach (string i in parcalanmısMetin)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < parcalanmısMetin.Length; i++)
//{
//       Console.WriteLine(parcalanmısMetin[i]);
//}
//foreach (char i in metin)
//{
//    Console.WriteLine(i);
//}

foreach (string i in parcalanmısMetin)
{
    
    foreach (char j in i)
    { Console.WriteLine(j); }


}
