// break, return, continue

#region continue

// 1-KullınıcıTamSayı tek sayıların toplamı 

//Console.WriteLine("Lütfen bir tamsayı giriniz");

//bool sonuc = int.TryParse(Console.ReadLine(), out int girilenSayi);

//int toplam = 0;

//if (sonuc)
//{
//	for (int i = 1; i <= girilenSayi; i++)
//	{
//		if (i % 2 == 0)
//			continue;

//		toplam += i;

//	}

//	Console.WriteLine($" 1'den {girilenSayi} e kadar olan tek sayıların toplamı  {toplam}");

//}
//else
//{
//	Console.WriteLine("HATA! Tamsayı girilmedi.");
//}
#endregion

//#region Break ve Return

//int sayi = 0;

//if (sayi < 100)
//{
//    for (sayi = 24; sayi < 50; sayi++)
//    {
//        if (sayi > 25)
//            break; // Döngüyü burada bitiriyor
//}

//for (sayi = 49; sayi <100; sayi++)
//{
//	if (sayi > 50)
//		return; // Metodu orada bitiriyor. Void tipinde geri döndüm
//}

//    for (sayi = 0; sayi < 50; sayi++)
//    {
//        if (sayi > 25)
//            break;
//    }

//}
//sayi += 5;
//Console.WriteLine("Sayı: " + sayi);

//#endregion


// ÖDEV 03.03.2024 //

/***** Ekrana 7'ler çarpım tablosunu yazan programı while döngüsü ile yazınız.*/

//int sonuc, i = 1, k = 7;

//while (i <= 10)
//{

//    sonuc = k * i;
//    Console.WriteLine(k + "x" + i + " = " + sonuc);
//    i++;

//}

/***** Klavyeden sıfır girilinceye kadar girilen sayıların kendisini ve karesini ekrana yazdıran program */



//while (true)
//{

//    Console.Write("Bir sayı giriniz: ");

//    int sayi = Convert.ToInt32(Console.ReadLine());


//    if (sayi != 0)
//    {
//        Console.WriteLine($"Sayı: {sayi} ve Karesi : " + sayi * sayi+ "\n");
//        continue;
//    }
//    else
//        Console.WriteLine("0 GİRDİĞİNİZ İÇİN İŞLEM BİTTİ.");
//        return;


//}


/*****  While Örnek 8: Kullanıcının girdiği iki sayının çarpımı toplama operatörü kullanarak bulunan program.(Çarpma işlemi kullanılmayacak)*/


//    Console.WriteLine("1. Sayıyı giriniz.");
//    int sayi1 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("2. Sayıyı giriniz.");
//    int sayi2 = Convert.ToInt32(Console.ReadLine());

//int çarpım = 0, i = 1 ;

//while (i <= sayi2)
//{
//    çarpım += sayi1;
//    i++;
//}

//Console.WriteLine("Çarpımları: " + çarpım);


/***** Kullanıcı tarafından klavyeden girilen 10 adet sayının 3'e, 5'e ve her ikisinede tam bölünenlerinin sayısını ekrana yazan program*/



//int sayac = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("{0}. sayıyı girin:", i + 1);
//    int sayi = Convert.ToInt32(Console.ReadLine());

//    if (sayi % 3 == 0 && sayi % 5 == 0)
//    {
//               sayac++;
//    }
//}
//Console.WriteLine("3'e ve 5'e tam bölünenlerin sayısı={0}", sayac);

/***** Do-While Örnek 1: Kullanıcı sifreyi "123" olarak girene kadar şifreyi soran program*/

//string sifre=" ";
//Console.WriteLine("Şifre giriniz");
//sifre = Console.ReadLine();

//if (sifre == "123")
//{
//    Console.WriteLine("Tebrikler! Doğru girdiniz.");
//}
//else
//{
//    do
//    {
//        Console.WriteLine("Hatalı Giriş Yaptınız! Lütfen tekrar giriniz");
//        sifre = Console.ReadLine();
//    } while (sifre != "123");

//    Console.WriteLine("Tebrikler! Doğru girdiniz.");

//}

/***** Do-While Örnek 2: Kullanıcı tarafından girilen 10 sayıdan kaç tanesinin 3 basamaklı olduğunu bulan program.*/

//int sayac = 0, i=0;
//do
//{
//    Console.WriteLine("{0}. sayıyı girin:", i + 1);
//    int sayi = Convert.ToInt32(Console.ReadLine().Trim());
//    string basamak = Convert.ToString(sayi);
//    i++;

//    if (basamak.Length == 3)
//        sayac++;


//} while (i <10);

//Console.WriteLine("Girdiğiniz {0} tane sayıdan {1} tanesi üç basamaklı sayıdır.", i, sayac);


/***** Break Örnek: Kullanıcı 'q' veya 'Q' karakterini girildiği anda döngüden break keywordü ile çıkınız.*/

//for (int i = 0; i < int.MaxValue; i++)
//{
//    Console.WriteLine("{0} harfi giriniz.", i + 1); 
//    string harf = Console.ReadLine().Trim();

//    if (harf == "q" || harf == "Q")
//        break;

//}

//Console.WriteLine("q ya da Q harfi girdiniz ve döngüyü bitirdiniz.");

/*****Continue Örnek: Kullanıcıdan kullanıcı sıfır girene kadar tamsayılar alınıyor. Kullanıcının girdiği sayı bir önceki sayıdan farklı olması isteniyor ve toplanıyor. Ekrana toplam yazılsın.(break, continue)*/

int toplam = 0, öncekiSayi = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("{0}. tamsayıyı giriniz: ", i + 1);
    int girilenSayi = Convert.ToInt32(Console.ReadLine().Trim());
    toplam += girilenSayi;

    if (girilenSayi == 0)
    {
        Console.WriteLine("0 girilene kadar girdiğiniz sayıların toplamı: " + toplam);
        break;

    }
    if (girilenSayi == öncekiSayi)
    {
        Console.WriteLine("\n Aynı sayıyı girdiniz. Lütfen farklı bir sayı giriniz.\n");
        continue;
    }
    öncekiSayi = girilenSayi;

}

