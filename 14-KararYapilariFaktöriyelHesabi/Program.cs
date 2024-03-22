//Faktöriyel Hesabı
// %! = 5 * 4 * 3 * 2 * 1
// 0! = 1, 1! = 1

Console.WriteLine("Lütfen faktöriyelini hesaplamak istediğiniz sayı değerini giriniz: ");

int sayi = Convert.ToInt32(Console.ReadLine());

int faktöriyel = 1, sayac = 1;
if (sayi < 0)
    goto negatif;
kontrol:
if (sayi == 0)
    faktöriyel = 1;

if (sayi > sayac)
{
    //sayac = sayac + 1;
    sayac++; // yukarıdaki ifade ile aynı anlama gelir

    faktöriyel = faktöriyel * sayac;
    goto kontrol;
}


Console.WriteLine(" Girilen sayı: " + sayi + " Faktöriyeli: " + faktöriyel);

negatif:

Console.WriteLine(" Girilen sayı negatif: " + sayi + " Faktöriyel hesaplanamaz");
