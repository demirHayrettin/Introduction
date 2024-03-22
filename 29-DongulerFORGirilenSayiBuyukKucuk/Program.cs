//int sayi, enKucukSayi = int.MaxValue, enBuyukSayi=int.MinValue;

int sayi, enKucukSayi = 0, enBuyukSayi = 0;



for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Lütfen {0} sayı giriniz.", i);
    sayi = Convert.ToInt32(Console.ReadLine());

    if (i == 1)
        enKucukSayi = enBuyukSayi = sayi;

    if (enKucukSayi > sayi)
        enKucukSayi = sayi;

    if (sayi > enBuyukSayi)
        enBuyukSayi = sayi;

}

Console.WriteLine("En büyük sayı: " + enBuyukSayi + " En küçük sayı: " + enKucukSayi);

