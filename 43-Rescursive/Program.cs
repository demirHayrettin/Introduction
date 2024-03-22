// Rescursive Method: Metot içinde metodun kendini çağırmasına denir. Özyinelemeli metot oalrakta bilinir.
//

#region Faktöriyel Hesabı

//// ÖRNEK: Kullanıcının girdiği sayının fatköriyelini Rescursive metot ile hesaplayınız. ve ekrana yaz.

//Console.WriteLine("FAKTÖRİYELİNİ HESAPLAMAK İSTEDİĞİNİZ SAYIYI GİRİNİZ");

//bool sayiMi = int.TryParse(Console.ReadLine(), out int girilenSayi);

//if (sayiMi)
//{
//    //FaktöriyelHesaplama(girilenSayi);

//    Console.WriteLine($"{girilenSayi} sayısının faktöriyeli : {FaktöriyelRescursive(girilenSayi)}");


//}
//else
//    Console.WriteLine("Girilen değer sayısal bir değer değil.");

///*
//5!
//5*4!
//5*4*3!
//5*4*3*2!
//5*4*3*2*1!
//5*4*3*2*1

// */

//static int FaktöriyelRescursive(int girilenSayi)
//{
//    if (girilenSayi == 1)
//        return 1;
//    else
//    {
//        return girilenSayi * FaktöriyelRescursive(girilenSayi - 1);
//    }
//}

//static void FaktöriyelHesaplama(int girilenSayi)
//{
//    int sayac = 1;
//    int faktöriyel = 1;

//    if (girilenSayi == 0)
//        faktöriyel = 1;
//    else if (girilenSayi < 0)
//        Console.WriteLine("Negatif sayının faktöriyeli hesaplanamaz");

//    else
//    {
//        while (sayac <= girilenSayi)
//        {
//            faktöriyel *= sayac;
//            sayac++;

//        }
//    }
//}

#endregion

#region Ardısık Sayı Hesabı
// ÖRNEK - 2: 1 ile 10 Arasındaki Ardışık Tek Sayıların Toplamı ve Ortalaması (Recursive Metot ile)

//int baslangic = 1;
//int bitis = 10;
//int toplam, sayac;
//double ortalamasi;

//ToplamVeOrtalamayıHesapla(baslangic, bitis, out toplam, out sayac, out ortalamasi);

//Console.WriteLine($"1 ile 10 arasındaki ardışık tek sayıların toplamı: {toplam}");
//Console.WriteLine($"1 ile 10 arasındaki ardışık tek sayıların ortalaması: {ortalamasi}");


//static void ToplamVeOrtalamayıHesapla(int baslangic, int bitis, out int toplam, out int sayac, out double ortalamasi)
//{
//    if (baslangic > bitis)
//    {
//        // Temel durum: Başlangıç değeri bitiş değerini geçerse, toplam ve ortalamayı hesapla
//        toplam = 0;
//        sayac = 0;
//        ortalamasi = 0;
//    }
//    else if (baslangic % 2 == 0)
//    {
//        // Başlangıç değeri çift ise atla, ardışık tek sayılarla devam et
//        ToplamVeOrtalamayıHesapla(baslangic + 1, bitis, out toplam, out sayac, out ortalamasi);
//    }
//    else
//    {
//        // Başlangıç değeri tek sayı ise toplama ekle, sayacı artır ve bir sonraki sayıya geç
//        ToplamVeOrtalamayıHesapla(baslangic + 2, bitis, out toplam, out sayac, out ortalamasi);
//        toplam += baslangic;
//        sayac++;
//        ortalamasi = (double)toplam / sayac;
//    }
//}

#endregion


#region Fibonacci Dizisi İlk On elemanı
//int n = 10; // İlk 10 Fibonacci sayısını hesaplamak için

//Console.WriteLine("Fibonacci Dizisinin İlk 10 Elemanı:");
//for (int i = 1; i < n; i++)
//{
//    Console.Write(Fibonacci(i) + " ");
//}

//static int Fibonacci(int n)
//{
//    if (n <= 1)
//    {
//        return n;
//    }
//    else
//    {
//        return Fibonacci(n - 1) + Fibonacci(n - 2);
//    }
//}
#endregion

#region Üs Hesaplama
int taban = 3;
int us = 4;

int sonuc = UsHesapla(taban, us);
Console.WriteLine($"{taban} üssü {us} = {sonuc}");


static int UsHesapla(int taban, int us)
{
    if (us == 0)
    {
        // Us 0 ise sonuç 1'dir
        return 1;
    }
    else if (us == 1)
    {
        // Us 1 ise sonuç tabandır
        return taban;
    }
    else
    {
        // Us pozitif bir değer ise tabanı us-1 kere çarparak hesapla
        return taban * UsHesapla(taban, us - 1);
    }
}
#endregion

#region Sonraki Ciftsayı ve Maksium
// SORU: Bir X sayısı tek ise 3 ile çarpılıp 1 ekleniyor.Çift ise 2'ye bölünüyor. İşlem X sayısı 1 olana kadar devam ediyor. Bu işlemin kaç adım sürdüğünü, işlem sırasında X sayısının aldığı maksimum değeri, X sayısının hangi sayıdan sonra hep çift olarak 1'e ulaştığını bulan algoritma ve akış diyagramı.

int X = 27; // X sayısını burada belirtebilirsiniz

int sayac = AdimSayisi(X, 0);
int maksimum = Maksimum(X, 0);
int sonrakiCiftSayi = SonrakiCift(X, 0);

Console.WriteLine($"İşlem adım sayısı: {sayac}");
Console.WriteLine($"Maksimum değer: {maksimum}");
Console.WriteLine($"X sayısı çift olup 1'e ulaşmadan önceki sonraki çift sayı: {sonrakiCiftSayi}");


static int AdimSayisi(int X, int sayac)
{
    if (X == 1)
    {
        return sayac;
    }

    if (X % 2 == 1)
    {
        X = 3 * X + 1;
    }
    else
    {
        X /= 2;
    }

    return AdimSayisi(X, sayac++);
}

static int Maksimum(int X, int maksimum)
{
    if (X == 1)
    {
        return maksimum;
    }

    if (X > maksimum)
    {
        maksimum = X;
    }

    if (X % 2 == 1)
    {
        X = 3 * X + 1;
    }
    else
    {
        X /= 2;
    }

    return Maksimum(X, maksimum);
}

static int SonrakiCift(int X, int sonrakiCiftSayi)
{
    if (X == 1)
    {
        return sonrakiCiftSayi;
    }

    if (X % 2 == 0 && sonrakiCiftSayi == 0)
    {
        sonrakiCiftSayi = X;
    }

    if (X % 2 == 1)
    {
        X = 3 * X + 1;
    }
    else
    {
        X /= 2;
    }

    return SonrakiCift(X, sonrakiCiftSayi);
} 

#endregion