// Kullanıcının klavyeden girdiği metni, kullanıcının girdiği tekrar sayısı kadar alt alta yazdıran

Console.WriteLine("Bir metin yazınız.");

metinGir:
string metin = Console.ReadLine().Trim().ToLower();

tamSayi:
Console.WriteLine("Kaç kez yazılmasını istiyorsunuz?");

uint i = Convert.ToUInt32(Console.ReadLine());

int k = 1;

while (k <= i)
{
    Console.WriteLine(metin);
    k++;

}


try

{
    
}
catch (OverflowException ex)
{
    Console.WriteLine("Döngü sayısını çok fazla girdiniz.");
    Console.WriteLine(ex.Message);

}
catch (FormatException ex)

{
    Console.WriteLine("Metin girmeniz gerekmektedir.");
    goto metinGir;
    
}
catch (Exception ex)

{
    Console.WriteLine("Metin girmeniz gerekmektedir.");
    goto tamSayi;

}

