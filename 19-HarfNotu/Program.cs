
Console.WriteLine("Öğrenci not ortalamasını giriniz.");

double not = Convert.ToInt32(Console.ReadLine());

if (not < 50)
    Console.WriteLine("Harf notu: DD ders tekrarı.");

else if (not <= 60 && not >= 50)

    Console.WriteLine("DC ile geçti.");

else if (not <= 70 && not >= 60)

    Console.WriteLine("BB ile geçti.");

else if (not <= 80 && not >= 70)
    Console.WriteLine("BA ile geçti");

else
    Console.WriteLine("AA ile geçti");
