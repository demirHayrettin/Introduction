using System.Globalization;
using System.Runtime.InteropServices;

namespace _41_MetotKeywords
{
    internal class program
    {
        static void Main(string[] args)
        {
            #region ref anahtar kelimesi

            //// ref Anahtar Kelimesi:
            ////Array.Resize(ref paramsArray, 0);

            //// ref keywordü kısaca benim çeride başıma gelen seninde dışarıda başına gelsin.

            //// örneğin; bir diziyi yeniden boyutlandırmak için kullanırız.Dizi ref anahtar kelimesi ile yeniden boyutlandırıldığında orjinal dizinin de yeni boyutu belirlenmiş olur.
            //string[] metinler = new string[5];

            //Console.WriteLine("Metinler adlı dizinin uzunluğu: "+ metinler.Length);
            //Array.Resize(ref metinler, 15);
            //Console.WriteLine("Metinler adlı dizinin uzunluğu: " + metinler.Length);

            //int aDegeri = 10, bDegeri = 20;
            //Console.WriteLine($"METODU ÇAĞIRMADAN ÖNCEKİ DEĞERLER: a:{aDegeri}, b: {bDegeri}");

            ////DegerleriDegistir(ref aDegeri, ref bDegeri);
            ////Console.WriteLine($"METODU ÇAĞIRDIKTAN SONRAKİ DEĞERLER: a:{aDegeri}, b: {bDegeri}");
            //RefsizDegerlerDegistir(aDegeri, bDegeri);
            //Console.WriteLine($"REFSİZ METODU ÇAĞIRDIKTAN SONRAKİ DEĞERLER: a:{aDegeri}, b: {bDegeri}");
            //void RefsizDegerlerDegistir(int a, int b)
            //{
            //    int gecici = a;
            //    a = b;
            //    b = gecici;
            //}

            //    void DegerleriDegistir(ref int a, ref int b)
            //{
            //    int gecici = a;
            //    a = b;
            //    b = gecici;
            //}

            #endregion


            #region out anahtar kelimesi

            // Eğer bir metot, dışarıya değer döndürmüyorsa (void metotsa) dşarıya değer döndürüyorsa dışarıya değer fırlatmak için, metot dışarıya değer döndürüyorsa birden fazla değeri dışarıya fırlatmak için kullanılır.


            //int.TryParse("", out int result); // bu metot ggeriye bool değer döner.



            //int sonuc, kalan;

            //BolmeIslemiYap(17, 5, out sonuc, out kalan);
            //Console.WriteLine("17 / 5 işleminin sonucu: {0} ve kalan: {1}", sonuc, kalan);

            //sonuc = BolmeYap(17, 5, out kalan);
            //Console.WriteLine("17 / 5 işleminin sonucu: {0} ve kalan: {1}", sonuc, kalan);


            //// Metodumuz void (geriye deger dondğrmeyen) metot olduğu için bolüm ve kalan değerlerini out ile dışarıya fırlatıyoruz.
            //void BolmeIslemiYap(int bolunen, int bolen, out int bolum, out int kalan)
            //{
            //    bolum = bolunen / bolen; // int hesaplama yapılacağı için bolüm tam sayı çıkacaktır.
            //    kalan = bolunen % bolen;
            //}
            //int BolmeYap(int boluneni, int bolen, out int kalan)
            //{
            //    kalan = boluneni % bolen;
            //    return boluneni / bolen;// bolum
            //}




            #endregion

            string[] kelimeler = new string[0];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bir kelime giriniz.");
                string kelime = Console.ReadLine();
                Array.Resize(ref kelimeler, kelimeler.Length + 1);
                kelimeler[i] = kelime;
                
                
            }
            Console.WriteLine(BirlestirlmisKelimeler(kelimeler));



            #region Params
            // Eğer



            // Ogrenci sınıfı oluşturun. Property ve 2-3 tane metot yazın.
            // Telefon sınıfı oluşturun. Property ve 2-3 tane metot yazın.

            //Topla(2,5);
            //Console.WriteLine("Toplma ödemeniz gereken tutar: "+ FiyatlarıTopla(2, 45, 87, 654, 9820, 456).ToString("₺0.00"));
            //Console.WriteLine("Toplma ödemeniz gereken tutar: "+ FiyatlarıTopla(2, 45, 87, 654, 9820, 456).ToString("C2"));
            //Console.WriteLine("Toplma ödemeniz gereken tutar: "+ FiyatlarıTopla(2, 45, 87, 654, 9820, 456).ToString("0.##"));
            //Console.WriteLine("Toplma ödemeniz gereken tutar: "+ String.Format(new CultureInfo("tr-TR"), FiyatlarıTopla(2, 45, 87, 654, 9820, 456).ToString("#,##0.00")));
        }
        static string BirlestirlmisKelimeler(params string[] kelimeler)
        {
            string girilenKelimeler="";
            foreach (string kelime in kelimeler)
            {
                girilenKelimeler += kelime+ "*";
            }
            return girilenKelimeler;
        }
        static double FiyatlarıTopla(double posetTutari, params double[] tutarlar)
        {
            double toplamTutar = 0;
            foreach (double fiyat in tutarlar)
            {
                toplamTutar += fiyat;
                
            }
            return toplamTutar+(posetTutari*tutarlar.Length/3);
        }   



        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        #endregion
    }

}
// Belirsiz tane kelime alan bu kelimeleri birleştirme metodu yazınız, birleştirmeyi kulalnıcıdan aldığı karakter ile yapınız.






