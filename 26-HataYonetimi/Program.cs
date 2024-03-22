// Derleme zamanı hataları

// Console.WriteLine("Hello World") // satırın sonunda mutlaka (;) noktalı virgül olmalıdır. Olmadığı durumda syntax hatası ortaya çıkar.

// string değer = 13; // Atama işlemlerinde eşitliğin sağındaki değer ile solundaki veri tipi uyumlu olmalıdır. Olmadığı durumda derleme zamanında hata alırız.

// Runtime (Çalışma) Hataları

// Kullanıcıdan telefon numarası alıp, eğer doğru formatta girildiyse doğru, yanlış formatta girildiyse yanlış mesajını ekrana yazdıran bir program yazınız.

// Doğru format : 10 haneli başınad 0 olmadan yazılmalıdır.(5336332536 gibi)
using System;

tekrarGiris:
Console.WriteLine("Lütfen telefon numarasını 10 haneli olacak şekikde giriniz. Başında 0 olmadan! (5336236566");

string kullanicidanGelen = Console.ReadLine(); // sağdaki metot string değer döndürdüğü için veri tipi ile uyumludur.
                                               // " 123 ".Trim() => "123"
                                               // " 123 ".TrimEnd() => " 123"
                                               // " 123 ".TrimStart() => "123 "

//Console.WriteLine(" 12 23 ".Replace(" ", ""));


#region TryParse
/*if (kullanicidanGelen.Trim().Length == 10 && kullanicidanGelen.StartsWith("5"))   */ // girilen değer 10 karekter mi?
//{
    // Kullanıcının girdiği değer 10 karakter ise bu bloktaki kodlar çalışacak.

   /* long telefonnumarasi = long.Parse(kullanicidanGelen);*/ // Format hatası alablir.
//    ulong telefonnumarasi;
//    bool sonuc = ulong.TryParse(kullanicidanGelen, out telefonnumarasi);
//    if (sonuc)
//    {
//        Console.WriteLine("Tebrikler! Doğru formatta giriş yaptınız!" + telefonnumarasi);
//    }

//    else
//    {
//        Console.WriteLine("İstenilen formatta giriş yapmadınız. Lütfen tekrar giriniz.");
//        goto tekrarGiris;
//    }
//}

//else
//    Console.WriteLine("İstenilen uzunluktan farklı bir uzunluktan farklı bir uzunlukta değer giridniz. ");


#endregion


#region tryCatch
//try
//{
//    Console.WriteLine("Lütfen telefon numarasını 10 haneli olacak şekikde giriniz. Başında 0 olmadan! (5336236566");
//    long telefonnumarasi = long.Parse(kullanicidanGelen);
//    Console.WriteLine("Tebrikler! Doğru formatta giriş yaptınız!" + telefonnumarasi);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine("KARDEŞİM MAL MISIN");
//} 
#endregion

#region Try Catch Finally

Console.WriteLine("Lütfen telefon numarasını 10 haneli olacak şekikde giriniz. Başında 0 olmadan! (5336236566");

string gelenBilgi = Console.ReadLine();

if (gelenBilgi.Trim().Length == 10 && gelenBilgi.StartsWith("5"))

{
    try
    {
        long telefonNumarasi = long.Parse(gelenBilgi); // 5DeniZafer patlatır
        Console.WriteLine("Tebrikler! Doğru formatta giriş yaptınız!" + telefonNumarasi);
        // veritabanına kaydet
    }
    catch (Exception)
    {
        Console.WriteLine("10 karekter anca yanlış format giriş yaptınız");
        // veritabanına kaydet
    }
    finally
    {
        Console.WriteLine("Başarılı olsa da olmasada buraya uğramasını istedim.");
        // Veritabanına kaydet
    }

}



#endregion

#region Exception Sınıflarından Bazıları
try
{
    Console.WriteLine("1. Sayıyı giriniz: ");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("2. Sayıyı giriniz: ");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    double sonuc = sayi1 / sayi2;
    Console.WriteLine("Sonuç: " + sonuc);
}
catch (FormatException ex)
{
    Console.WriteLine("Format Exception hatası oluştu.");
    Console.WriteLine(ex.Message);
}
catch (OverflowException ex)
{
    Console.WriteLine("OverFlowException hatası oluştu.");
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("DivideByZeroException hatası oluştu.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("OverFlowException hatası oluştu.");
    Console.WriteLine(ex.Message);
}

#endregion