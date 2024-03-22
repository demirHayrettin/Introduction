//1.Adım: Başla
//2. Adım: Kullanıcıdan suyun derecesini ölçmesini ve derecesini girmesini iste (suDerece)
//3. Adım: Eğer(suDerece <= 0) ise ekrana "katı" yaz, Aksi Halde eğer (0 < suDerece ve suDerece <= 100) ise ekrana "sıvı" yaz, Aksi Halde (100 < suDerece) ise ekrana "Gaz" yaz
//4. Adım: Bitir

using System;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Lütfen su sıcaklığı derecesini Celcius cinsinden giriniz: ");
double suSicakliği = Convert.ToDouble(Console.ReadLine());

if (suSicakliği > 100)
{
    // statement

    Console.WriteLine("Su Gaz Halindedir");

    //
    //
    //
    //
    //
    //

}
else if (suSicakliği == 100)
{
    Console.WriteLine("Su Sıvı ya da Gaz Halindedir");

}
else if (suSicakliği < 0)

{
    Console.WriteLine("Su Katı Halindedir");

}
else if (suSicakliği == 0)
{ Console.WriteLine("Su Katı Halindedir");
}
else
{
    Console.WriteLine("Sıvı");



}

