int toplam = 0;

// I.yol

//for (int i = 2; i <= 50; i = i + 2)
//{
//    //int toplam = 0;local değişken
//    toplam += i; // toplam = toplam + i; // *=  -=  += /=
//}

//Console.WriteLine(toplam);

// II. YOL

for (int i = 1; i <= 50; i++)
{
    //if (i % 2 == 1) sayı tek ise
    //if (i % 2 != 1) sayı çif ise
    if (i % 2 != 1)  // sayı çif ise
        toplam += i;

}

Console.WriteLine(toplam);

//for (int i = 0; i < 10; i++)
//    Console.WriteLine(i); tek satırda scop a gerek yok örneği