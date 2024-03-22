// Do While

/*
 * do
 * {
 *    // statement
 *  
 *  } while (koşul);
 *  
 *  */


// Faktöriyel örneği
// 

int faktoriyel = 1, girilenSayi;

Console.WriteLine("Fakötriyel hesabını şstediğiniz sayıyı giriniz.");

bool sonuc = int.TryParse(Console.ReadLine(), out girilenSayi);

if (sonuc)
{
    if (girilenSayi == 0)
    {
        Console.WriteLine("Girilen sayı sıfır olduğundan farktöriyeli 1'dir.");
    }
    else if (girilenSayi > 0)
    {
        do
        {
            faktoriyel *= girilenSayi;
            girilenSayi--;
            // girilenSayi = girilenSayi -1;
            // girilenSayi -= 1

        } while (girilenSayi >= 1);

        Console.WriteLine("{0}! = {1}", girilenSayi, faktoriyel);
    }

    else
    {
        Console.WriteLine("Negatif sayıların faktöriyeli hesaplanamaz.");
    }

}
else
    Console.WriteLine("Hata! Numerik olmayan bir ifade girdiniz. İşlem yapılamıyor.");



// // 1' den 1000'e kadar olan sayılar içerisinde 5'e tam bölünen aynı zamanda 7'ye tam bölünemeyen sayıları sayan, toplamlarını hesaplayan ve bu sayıları listeleyen programı yazınız.



//int i = 1, toplam = 0, sayac = 0;

//string dizi = "";

//while (i <=1000)
//{

//    if (i %5 == 0 && i %7 !=0)
//    {
//        sayac++;   
//        toplam += i;
//        dizi += i + ",";
//    }

//    i++;
//}
//Console.WriteLine($"Toplam: {toplam} \n Sayac: {sayac}\n Liste: {dizi}");


//Yıldızlarla oluşan dörtgenin satır ve sütun sayısı sabit olmayacak şekilde(Kullanıcıdan alınacak) dörtgen oluşturan program.Örnek çıktısı 4x15lük is
int sayi1, sayi2;

Console.WriteLine("Uzun kenar giriniz.");

sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kısa kenar giriniz.");

sayi2 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <=sayi1; i++)
{
    for (int j = 0; j < sayi2;j++)
    {
        Console.Write("*");
    }
    // Console.WriteLine();
    Console.WriteLine("\n");
}

  



