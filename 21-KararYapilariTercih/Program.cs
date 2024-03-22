// Kullanıcıdan alınan tercih bilgisine göre hangi içeceği tercih ettiğini ekrana yazdıran program. (c:çay, L: Limonata, G: Gazoz, K: Kola)

tekrarsec:
Console.WriteLine("İçecek olarak ne alırsınız? \n (C:çay, L: Limonata, G: Gazoz, K: Kola)");

char icecekTercihi = Convert.ToChar(Console.ReadLine());


#region elseif
//if (icecekTercihi == 'c' || icecekTercihi == 'C')
//    Console.WriteLine("Çay Tercih Ettiniz.");

//else if (icecekTercihi == 'g' || icecekTercihi == 'G')
//    Console.WriteLine("Gazoz Tercih Ettiniz.");

//else if (icecekTercihi == 'l' || icecekTercihi == 'L')
//    Console.WriteLine("Limonata Tercih Ettiniz.");

//else if (icecekTercihi == 'k' || icecekTercihi == 'K')
//    Console.WriteLine("Kola Tercih Ettiniz.");

//else
//    Console.WriteLine("Yanlış tercih ettiniz tekrar ne içmek istediğinizi belirtiniz.");
//        goto tekrarsec; 
#endregion


#region Switch Case
// switch case

switch (icecekTercihi)
{
    case 'c':
    case 'C':
        Console.WriteLine("Çay Tercih Ettiniz.");
        break;
    case 'l':
    case 'L':
        Console.WriteLine("Limonata Tercih Ettiniz.");
        break;
    case 'g':
    case 'G':
        Console.WriteLine("Gazoz Tercih Ettiniz.");
        break;
    case 'k':
    case 'K':
        Console.WriteLine("Kola Tercih Ettiniz.");
        break;
    default:
        Console.WriteLine("Yanlış tercih ettiniz tekrar ne içmek istediğinizi belirtiniz.");
        goto tekrarsec;
} 
#endregion