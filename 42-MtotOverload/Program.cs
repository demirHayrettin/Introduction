// Metot Overloading: Aynı isimde birden fazla metot tanımlayarak metot overloading işlemi denir.
// Kural olarak, parametrelerin tipi ya da sayısı yani imzası farklıdır.

using System.Reflection.Metadata;

namespace _42_MtotOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Ortalama Double: "+OrtalamayıBul(20.5, 63.5));
            //Console.WriteLine("Ortalama Int: "+OrtalamayıBul(7, 122));

            Console.WriteLine(OrtalamayıBul(12.55m,36.56m));
            Console.WriteLine(OrtalamayıBul(12.5,36.5,63.5));
            Console.WriteLine(OrtalamayıBul(12.55,36.56,36.98,654.85));

        }

        // iki tane decimal alan overload metot
        // 3 tane double alan overload metot
        // double tipinde belirsiz sayıda değer alan ve double döndüren overload metot


        static decimal OrtalamayıBul(decimal sayi1, decimal sayi2)
        {
            return (sayi1 + sayi2)/2;
        }
        static double OrtalamayıBul(double sayi1, double sayi2,double sayi3)
        {
            return (sayi1+ sayi2+sayi3)/3;
        }
        static double OrtalamayıBul(params double[]  sayilar)
        {
            double toplam = 0;
            foreach (double sayi in sayilar)
            {
                 toplam+= sayi;
            }

            return toplam/sayilar.Length;
        }


        // GeriDönüşVeriTipi Metodunİsmi(veritipi değişken, veritipi değişken,....)

        /// <summary>
        /// 2 adet double sayıyı parametre olarak alıp geriye double tipinde sonuc döndürür
        /// </summary>
        /// <param name="sayi1">Ortalamaya dahil edilecek double tipindeki bir sayı</param>
        /// <param name="sayi2">Ortalamaya dahil edilecek double tipindeki bir sayı</param>
        /// <returns>Yapılan işlem sonucunda geriye double tipind değer döndürür.</returns>
        static double OrtalamayıBul(double sayi1, double sayi2)
        {
            return (sayi1+sayi2)/2;
        }
        // GeriDönüşVeriTipi Metodunİsmi(veritipi değişken, veritipi değişken,....)

        /// <summary>
        /// 2 adet int sayıyı parametre olarak alıp geriye int tipinde sonuc döndürür
        /// </summary>
        /// <param name="sayi1">Ortalamaya dahil edilecek int tipindeki bir sayı</param>
        /// <param name="sayi2">Ortalamaya dahil edilecek int tipindeki bir sayı</param>
        /// <returns>Yapılan işlem sonucunda geriye int tipinde değer döndürür.</returns>
        static int OrtalamayıBul(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2) / 2;
        }
    }
}