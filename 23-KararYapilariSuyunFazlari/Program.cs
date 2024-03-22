// Suyun Fazlari


Console.WriteLine("Su sıcaklığını celcius cinsinden giriniz");

int suSicakligi = Convert.ToInt32(Console.ReadLine());

switch (suSicakligi)
{
    case < 0:
        Console.WriteLine("Su katı haldedir.");
        break;
    case > 100:
        Console.WriteLine("Su gaz haldedir");
        break;
    default:
        Console.WriteLine("Su sıvı haldedir");
        break;
}