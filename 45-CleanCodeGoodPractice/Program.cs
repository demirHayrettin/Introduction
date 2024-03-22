/*
1. Değişken, Metot, Sınıf isimleri kullanırken anlaşılır isimler kullanın. 
ÖRNEK: int x yerine int girilenSayi ya da int sayi gibi.

2. Değişken, Metot, Sınıf isimlendirmeleri yaparken camelCasing / PascalCasing notasyonuna dikakt edelim. değişkenler camelCasing, Sınıf Metot, Property PascalCasing

Örnek: int Counter yerine int counter.

3. 
3. Düzen biçimlendirmesine dikkat edelim. Ctrl + K + D tuş kombinasyonuna basıyoruz.

4. Eğer bir değişkene başlangıç değeri de atayacaksak, tanımladığımız yerde yapabiliriz. Aynı tipdeki değişkenleri yanyana virgüllerle ayırarak yazabiliriz.

Örnek: int sayi = 0, sayac = 1;

5. Gerekli yerlere abartılı olmayacak şekilde yorum satırları ekleyebilirim.Bu yorum satırları metotlarda summury satırı olabilir. /// 

6. Kodlarınızı yeniden kullanılabilir olarak yazınız. Metotlar, sınıflar 

7. Karar yapılarından veya metotlardan kullanılacak olan değerler sabit ise bu değerleri ilgili yapının tanımlandığı yerde yazınız.

Örnek: if(kullanicininYetkisi == "Müdür") yerine 
// string mudurYetkisi = "Müdür"
if(kullanicininYetkisi == mudurYetkisi) şeklinde tanımlayalım.

8. Metot zincirlemeyi kullanın

Örnek: Gelen metni küçük harf, türkçe olamadan boşluksuz olarak ele alalım.

string deger = "Bilge Adam Akademi Boost Yıldız Yazılımcı Yetiştirme Proğramı";

string [] kelimeler =deger.ToLower().Replace('ı', 'i').Replace('ş', 's').Replace('ğ', 'g').Replace('ç', 'c').Replace('ö', 'o').Split(' ');

9. Kullanılabilen yerlerde karar yapısı oalrak Ternary If kullanabiliriz.

10. Uzun kod bloglarında region ifadesini kullanın! Ctrl+ K + S tuş kombinasyonu ile gelen snippitlardan seçiyoruz.

11. Hata yakalamak için Try-Catch bloglarını kullanabilir ve istisnaları özelleştirebiliriz.

 */




int sayi, sayac = 0, maksimumSayi = 0, ciftMaksimumSayi = 0;

bool sayiMi = kullanicidanSayiAl(out sayi);

if (sayiMi && sayi >= 0 && sayi !=1)
{
    DegerleriBul(out ciftMaksimumSayi, out maksimumSayi, out sayac);

    DegerleriEkranaYaz(ciftMaksimumSayi, maksimumSayi,sayac);
}

// <summary>
/// Maksimum sayı, çift maksimum sayı ve sayac değerlerini ekrana yazdırır.
/// </summary>
/// <param name="maksimumSayi">Maksimum sayı değeri</param>
/// <param name="ciftMaksimumSayi">Çift maksimum sayı değeri</param>
/// <param name="sayac">Sayaç değeri</param>
void DegerleriEkranaYaz(int ciftMaksimumSayi, int maksimumSayi, int sayac)
{
    Console.WriteLine("Bu işlem sırasında ulaşılan maksimum sayı: "+ maksimumSayi);
    Console.WriteLine("Bu işlem sırasında ulaşılan çift maksimum sayı: " + ciftMaksimumSayi);
    Console.WriteLine("Bu işlem bitene kadarki adım sayısı: "+ sayac);

}

// <summary>
/// Gerekli döngüyü kullanarak değerleri bulur.
/// </summary>
/// <param name="ciftMaksimumSayi">Çift maksimum sayı değerini alır, değeri bulduktan sonra dışarıya fırlatır</param>
/// <param name="maksimumSayi">Maksimum sayı değerini alır, değeri bulduktan sonra dışarıya fırlatır</param>
/// <param name="sayi">Girilen sayı değeri</param>
/// <param name="sayac">Sayaç değeri</param>
void DegerleriBul(out int ciftMaksimumSayi, out int maksimumSayi, out int sayac)
{
    ciftMaksimumSayi = maksimumSayi = sayac = 0;
    while (sayi>=2)
    {
        sayac++;
        if (sayi %2 == 1 )
        {
            sayi = (sayi * 3) + 1;
            sayac++;
            ciftMaksimumSayi = 0;
        }
        ciftMaksimumSayi= ciftMaksimumSayi < sayi ? sayi : ciftMaksimumSayi;
        maksimumSayi = maksimumSayi< sayi ? sayi: maksimumSayi;
        sayi /= 2;
    }

}

//<summary>
///Kulalnıcıdan değer alıp, değeri int türüne dönüştürmeyi dener.
///</summary>
///<param name="sayi">int türünde bir tam sayı giriniz</int>/param>
///<returns> Eğer değeri int türüne dönüştürebilirse true, aksi halde false döner</returns>
///


static bool kullanicidanSayiAl(out int sayi)
{
    Console.WriteLine("Lütfen bir pozitif tam sayı giriniz.");
    return int.TryParse(Console.ReadLine(), out sayi);
}


