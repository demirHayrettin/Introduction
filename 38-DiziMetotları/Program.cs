//Dizide bulunan 10 sayıyı küçükren büyüğe sıralama

//int[] intArray = new int[10];

//for (int i = 0; i < intArray.Length; i++)
//{
//    Random rnd = new Random();
//    intArray[i] = rnd.Next(0, 100);

//}


//for (int i = 0; i < intArray.Length; i++)
//{
//    for (int j = 0; j < intArray.Length; j++)
//    {

//        if (intArray[i] < intArray[j])
//        {
//            int temp = intArray[j];

//            intArray[j] = intArray[i];
//            intArray[i] = temp;
//        }
//    }
//}

//foreach (int elemanlar in intArray)
//{
//    Console.WriteLine(elemanlar);
//}

//int[] sayilar = { 10, 20, 8, 5, 32, 45, 99, 23 };

//foreach (var item in sayilar)

//{
//    Console.Write(item + " ");
//}

//Console.WriteLine("Küçükten büyüğe sıralanmış dizi (sort metodu ile)");

//Array.Sort(sayilar);

//foreach (var item in sayilar)

//{
//    Console.Write(item + " ");
//}

//Console.WriteLine("Büyükten küçüeğesıralanmış dizi (reverse metodu ile)");

//Array.Reverse(sayilar);

//foreach (var item in sayilar)

//{
//    Console.Write(item + " ");
//}

//using System.ComponentModel.DataAnnotations;
//using System.Runtime.InteropServices;

//string[] sehirler = { "Ankara", "İstanbul", "Bursa", "Erzurum", "Çanakkale", "Bilecik", "İzmir", "Kars" };
//Array.Sort(sehirler);

//foreach (var item in sehirler)

//{
//    Console.Write(item + " \n");
//}

//Array.Reverse(sehirler);

//foreach (var item in sehirler)

//{
//    Console.Write(item + " ");
//}


//sistem.Array sınıfı - dizi özellikleri ve metotları

///*
//Dizi olarak tanımladığımız değişkenleri Arrya sınıfından türemiş olduklarından dolayı sahip oldukları özellikleri ve metotlar vardır.


//Özellikler

//Length: Dİzideki eleman sayısını verir(int)
//IsReadOnly: Dizideki elemanların sadece okunabilir olup olmadığını söyler.(bool)
//IsFixedSize: Dizinin eleman sayısının sabit olup olmadığını döner.(bool)
//Rank: Dizinin boyutunu verir.(int)

//*/

//Console.WriteLine("Eleman sayısı: "+ sehirler.Length );
//Console.WriteLine("Sabit mi ? " + (sehirler.IsFixedSize ? "Evet" : "Hayır"));
//Console.WriteLine("Dizinin boyutu: " + sehirler.Rank);

///*
//METOTLAR:

//sort(): Bir boyutlu diziyi sıralamaya yarar.
//Reverse(): Diziyi tersine çevirir.
//Copy(): Dizinin bir bölümünü başak bir diziye kopyalar. Gerekli tür dönüşümü ve boxing işlemleri yapılır.
//CopyTo(): Diziyi kopyalar.
//IndexOf(): Dizi içerisindeki bir değerin indexini verir.
//SetValue(): Bir dizinin bir elemanına değer atar.
//GetLength(): Dizideki eleman sayısını verir.
//Resize(): Dizinin uzunluğunu değiştirmeyi sağlar.
//GetValue(): Dizideki ilgili elemanın değerini verir.
//Clear (): Dizi içerisindeki elemanaları varsayılan değer taşır.

//*/

//string[] isimler = { "Bilge", "Adam", "Boost", "Yıldız", "Yazılımcı" };

//foreach (var item in isimler)
//{
//    Console.Write(item + " ");
//}

//Console.WriteLine("Dizinin eleman sayısı: " + isimler.Length);
//Console.WriteLine("Dizinin eleman sayısı: " + isimler.GetLength(0)); // 1. boyutunda ki length i verir
//Console.WriteLine("Dizinin boyutu:  " + isimler.Rank); // Dizinin boyutu: 1

//string[] isimler2 = new string[10];
//isimler.CopyTo(isimler2, 4);

//foreach (var item in isimler2)
//{
//    Console.WriteLine(item);
//}

// isimler[6] = "Yetiştirme"; Dizi burada 5 elemanlı . 6. elemana atama yaparken hata veriyor.

//Array.Resize(ref isimler, isimler.Length + 1);

//isimler[6] = "Yetiştirme";

//int[] intArray;


//kullanıcı istediği kadar öğrencinin bilgisini girecek. adı, soyadı, doğum tarihi, Cinsiyeti (E / K)TCNo, kilosu (double) bilgilerini ayrı arraylerde tanımlayınız. 10 kişi tamamlanınca tüm bilgileri öğrenci bazında satır satır Ekrana yazınız.Diziler sıfırdan başlayacak.

Console.WriteLine("Öğrencilerin bilgilerini giriniz.");

string[] isimler = new string[0];
string[] soyİsimler = new string[0];
string[] dogumTarihleri = new string[0]; // DateTime
string[] cinsiyetler = new string[0]; // Char
long[] tcler = new long[0];
double[] kilolar = new double[0];
int sayac = 0;

for (int i = 0; i < int.MaxValue; i++)
{
    Console.WriteLine($"{i + 1}. ögreci adı: ");
    Array.Resize(ref isimler, isimler.Length + 1);
    isimler[i] = Console.ReadLine();

    Console.WriteLine($"{i + 1}. ögreci soyad: ");
    Array.Resize(ref soyİsimler, soyİsimler.Length + 1);
    soyİsimler[i] = Console.ReadLine();

    Console.WriteLine($"{i + 1}. ögreci doğum tarihi: ");
    Array.Resize(ref dogumTarihleri, dogumTarihleri.Length + 1);
    dogumTarihleri[i] = Console.ReadLine();

    Console.WriteLine($"{i + 1}. ögreci cinsiyeti: ");
    Array.Resize(ref cinsiyetler, cinsiyetler.Length + 1);
    cinsiyetler[i] = Console.ReadLine();

    Console.WriteLine($"{i + 1}. ögreci Tc: ");
    Array.Resize(ref tcler, tcler.Length + 1);
    tcler[i] = Convert.ToInt64(Console.ReadLine());

    Console.WriteLine($"{i + 1}. ögreci kiosu: ");
    Array.Resize(ref kilolar, kilolar.Length + 1);
    kilolar[i] = Convert.ToDouble(Console.ReadLine());

    sayac++;

    if (sayac % 10 == 0)

    {
        for (int j = sayac - 10; j < sayac; j++)
        {
            Console.WriteLine($"{j + 1}. Öğrenci Adı: {isimler[j]} \\  Soyadı: {soyİsimler[j]} \\ Doğum Tarihi: {dogumTarihleri[j]}\\ Cinsiyeti: {cinsiyetler[j]} \\  TC: {tcler[j]} \\  Kilosu: {kilolar[j]} kg ");
        }


    }



}

