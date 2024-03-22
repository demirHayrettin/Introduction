//2)Bir fabrikada sabit maaşla çalışan işçiler, aile durumlarına göre ek maaş almaktadır.Bekar olanlar sadece maaş, evli ve çocuğu olmayanlar % 3 ek maaş, çocuk sayısı 1 olanlar % 5 ek maaş, çocuk sayısı 2 olanlar % 10 ek maaş, çocuk sayısı 3 ve daha fazla olanlar ise % 15 kadar ek maaş almaktadır. Bu göre, kullanıcıdan işçinin maaşı ve çocuk sayısını isteyerek, gerekli hesaplamayı yapıp ekrana yazdıran program.

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Lütfen  maaşınızı giriniz");

double maas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Lütfen medeni durumunuzu giriniz? (Bekar ise B'ye Evli ise E'ye basınız)");

char medeniDurum = Convert.ToChar(Console.ReadLine().ToLower());

if (medeniDurum == 'b')

    Console.WriteLine("Maaşınız: " + maas);

else if (medeniDurum == 'e')

{
    Console.WriteLine("Çoçuğunuz var mı? Var ise sayısını girniz.Yok ise 0 giriniz");
    cocukSayisi: int cocukSayisi = Convert.ToInt32(Console.ReadLine());

    if (cocukSayisi < 0)
    {
        Console.WriteLine("Geçersiz giriş yaptınız. Çocuk sayısını tekrar giriniz: ");
        goto cocukSayisi;
    }
    else if (cocukSayisi == 1)
    {
        Console.WriteLine("Maaşınız: " + (maas * 1.05));
    }

    else if (cocukSayisi == 2)
    {
        Console.WriteLine("Maaşınız: " + (maas * 1.1)); // Math.Round(value, 2) 2 basamaklı değere sabitler.
    }
    else if (cocukSayisi == 3)
    {
        Console.WriteLine("Maaşınız: " + (maas * 1.15)); // string.Format bakılacak türlerine.
    }

    else

        Console.WriteLine("Maas: " + (maas * 1.03));

}
