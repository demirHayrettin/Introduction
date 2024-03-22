int x, Counter, MaxX, ciftMaxX;

x= Convert.ToInt32(Console.ReadLine());

Counter = 0;
MaxX = 0;
ciftMaxX = 0;

if (x != 1)
{
    while (x >= 2)
    {
        Counter = Counter + 1;
        if (x % 2 == 1)
        {
            x = (x * 3) + 1;
            Counter = Counter + 1; ;
            ciftMaxX = 0;
        }
        if (ciftMaxX < x)
        {
            ciftMaxX = x;
        }
        if (MaxX < x)
        {

            MaxX = x;
        }
        x = x / 2;
    }
    Console.WriteLine(MaxX);

    Console.WriteLine(ciftMaxX);
    Console.WriteLine(Counter);

}
else
    Console.WriteLine("Sayıyı 1 girdiniz.");
