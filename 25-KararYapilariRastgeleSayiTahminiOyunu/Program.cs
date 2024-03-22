int tutulanSayi, sayac = 1;

Random rnd = new Random();

tutulanSayi = rnd.Next(1, 101);

Console.WriteLine("*******SAYI TAHMİN OYUNU*******");

yeniTahmin:
Console.WriteLine("Lütfen 1-100 arasında bir tam sayı giriniz.");
byte tahminedilenSayi = Convert.ToByte(Console.ReadLine());

if (sayac <= 10)

{
    if (tahminedilenSayi == tutulanSayi)
        Console.WriteLine("Tebrikler" + sayac + ". tahminde doğru bildiniz.");

    else if (tutulanSayi < tahminedilenSayi)
    {
        Console.WriteLine("Lürfen daha küçük bir sayı giriniz.");
        sayac++;
        goto yeniTahmin;
    }
    else

    {
        Console.WriteLine("Lütfen daha büyük sayı giriniz.");
        sayac++;
        goto yeniTahmin;

    }
}
else

    Console.WriteLine("10 hakkınızın tamamını kullandınız. Sayıyı doğru tahmin edemediniz.");













