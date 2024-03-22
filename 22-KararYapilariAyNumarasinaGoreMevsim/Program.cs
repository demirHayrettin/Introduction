// Ay numarasına göre mevsim
// 12-1-2 için Kış, 3-4-5 İlkbahar, 6-7-8 için Yaz, 9-10-11 için Sonbahar

using System;

aybilgisi: 

Console.WriteLine("Hangi mevsimde olduğunuzu öğrenmek için bulunduğunuz ayın numarasını giriniz. \n Lütfen 1 ile 12 arasında bir değer giriniz.");

int ay = Convert.ToInt32(Console.ReadLine());

#region elseif
if (ay == 12 || ay == 1 || ay == 2)

    Console.WriteLine("Kış Mevsimindesiniz");

else if (ay == 3 || ay == 4 || ay == 5)

    Console.WriteLine("İlkbahar Mevsimindesiniz");

else if (ay == 6 || ay == 7 || ay == 8)

    Console.WriteLine("Yaz Mevsimindesiniz");
else if (ay == 9 || ay == 10 || ay == 11)

    Console.WriteLine("Sonbahar Mevsimindesiniz");
else
    Console.WriteLine("Girdiğiniz değer 1 ile 12 arasında değil.");
goto aybilgisi;

#endregion



#region switchCase
switch (ay)

{
    case (12):
    case (1):
    case (2):
        Console.WriteLine("Kış Mevsimindesiniz");
        break;
    case (3):
    case (4):
    case (5):
        Console.WriteLine("İlkbahar Mevsimindesiniz");
        break;
    case (6):
    case (7):
    case (8):
        Console.WriteLine("Yaz Mevsimindesiniz");
        break;
    case (9):
    case (10):
    case (11):
        Console.WriteLine("Kış Mevsimindesiniz");
        break;

    default:
        Console.WriteLine("Girdiğiniz değer 1 ile 12 arasında değil.");
        goto aybilgisi;

} 
#endregion



