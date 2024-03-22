// Metotlar:

// Bir kod parçasını, program akışı içerisinde birden fazla kullanıyorsak; metot oluşutrusak daha mantıklı olan seçenektir. Çünkü metot kullanımı ile daha az satırda kod yazılmış olur.Daha merkezi kontrol oluşturulmuş olur.

/* Clean Kod

// Metotlar 2 'ye  ayrılır. // 
1. Geriye değer döndürmeyenler (void)
1.1 Parametresiz Metotlar
1.2 Parametreli Metotlar

2. Geriye değer döndürenler (string int object vb.)
2.1 Parametresiz Metotlar
2.2 Parametreli Metotlar

*/


//METOT ÖRNEKLERİ
//Console.WriteLine(); // PARAMETRELİ, VOİD, 17 OVERLOAD
//Console.ReadLine(); // PARAMETRESİZ, STRİNG
//Array.Reverse // PARAMETRELİ, VOİD, 3 OVERLOAD
//Array.Sort // PARAMETRELİ, VOİD, 16 OVERLOAD
//Next // PARAMETRELİ, INT, 2 OVERLOAD
//Round // PARAMETRELi DOUBLE, 7 OVERLOAD
//Replace // PARAMETRELi STRİNG, 3 OVERLOAD

using System.ComponentModel.Design;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace _39_MetotTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // İki sayının toplmaı
            // Geriye Değer Döndürmeyen Parametresiz Metotlar

            // Math.Abs(50);
            // COnsole.WriteLine("");
            // COnsole.ReadLine();
            //Convert.ToByte();
            //String.FOrmat();
            //Array.CLear();
            // Random rnd = new Random ();
            // rnd.Next();

            //ToplamaYap1(); // Bir Metodun içerisinde başka bir metodu çağırırım. Main metodu içerisibde Toplam1 metodunu çağırıryorum.

            //int geriDonenDeger = ToplamaYap2(); // PArametre almayan ama geriye değer dondüren bir metot.

            //ToplamaYap3(15, 25); // Parametre alan ve geriye değer döndürmeyen

            //int geriDonenDeger2 = ToplamaYap4(25, 14);
            //Console.WriteLine("İki sayının toplamıdan dönen değer: " + geriDonenDeger2);

            //string cevap = ToplamaYap5(25.5f, 52.6f);
            //Console.WriteLine(cevap);

            //Console.WriteLine(ToplamaYap5(52.5f, 63.21f));

            //// kullanıcıdan alınan 3 tam sayının toplamını tamamlayıp ekrana yazdıran metot

            //Console.WriteLine("1. TAM SAYI GİRİNİZ");

            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. TAM SAYI GİRİNİZ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3. TAM SAYI GİRİNİZ");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(ToplamaYap6(sayi1, sayi2, sayi3));



            //// Varsayılan değere sahip metot oluşturdu.
            //// Kullanıcıdan adını alan ve Merhaba kullanıcı adı yazdıran metot. Kulalnıcı adını girmezse merhaba dostum yazan metot


            //Console.WriteLine("Kullanıcı adınızı girin.");
            //string kullaniciAdi = Console.ReadLine();

            //Selamla();

            //Selamla(kullaniciAdi);

            //// Farklı Sırada Parametre Göndermek

            //EkranaYaz("Bilge", "Adam", "Akademi");

            //EkranaYaz(gelenDeger3: "Yazımlımcı",gelenDeger2: "Boost",gelenDeger1: "Yıldız");

            //Yaz();  


            //Console.WriteLine("1. sayı giriniz.");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. sayı giriniz.");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Toplamları: "+Toplama(sayi1, sayi2));
            //Console.WriteLine("Çarpımları: " + Carpma(sayi1, sayi2));


            //Console.WriteLine("Karesini almak istediğiniz sayıyı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Karesi: " + KareAl(sayi));

            //BirIleYuz();

            //Console.WriteLine("Bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //BirIleSayi(sayi);


            //int sayi1 = KullanıcıdanTamSayiDegeriAl();
            //int sayi2 = KullanıcıdanTamSayiDegeriAl();

            //Console.WriteLine("İki sayının toplmının Kupü: "+ ToplamKup(sayi1, sayi2));


            //TekCift(KullanıcıdanTamSayiDegeriAl());

            Enbuyuk();

        }


        //Bir tamsayı alan ve tamsayı basamaklarını çözümleyen bir program yazınız. (10 puan)

        //Girilen ifadenin doğru bir tamsayı olup olmadığı kontrol etmelisiniz.Eğer ki kullanıcının giriş yaptığı değer bir tamsayı değilse, kullanıcıdan doğru formatta bir sayı istemelisiniz.  
        //Ayrıca yapılacak işlemler kesinlikle tamsayı tipindeki değişkenler kullanılarak yapılmalıdır.Bu uygulamada string metotları kullanılmayacaktır.Kullanıcının programı sonlandırmak için sayı giriş aşamasında “exit” yazılması gereklidir.

        //2837 sayısı için sonuç aşağıdaki gibi görünmelidir:

        //7 x 1 = 7

        //3 x 10 = 30

        //8 x 100 = 800

        //2 x 1000 = 2000

      
        static void OgrenciListesi()
        {
            Console.WriteLine("Öğrencilerin bilgilerini giriniz.");

            string[] isimler = new string[0];
            string[] soyİsimler = new string[0];
            DateTime[] dogumTarihleri = new DateTime[0]; 
            char[] cinsiyetler = new char[0]; 

            long[] tcler = new long[0];
            double[] kilolar = new double[0];
            int sayac = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine($"{i + 1}. ögreci adı: ");
                Array.Resize(ref isimler, isimler.Length + 1);
                isimler[i] = Console.ReadLine();

                Console.WriteLine($"{i + 1}. ögreci soyad: ");
                Array.Resize(ref soyİsimler, soyİsimler.Length + 1);
                soyİsimler[i] = Console.ReadLine();

                Console.WriteLine($"{i + 1}. ögreci doğum tarihi: ");
                Array.Resize(ref dogumTarihleri, dogumTarihleri.Length + 1);
                dogumTarihleri[i] = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine($"{i + 1}. ögreci cinsiyeti: ");
                Array.Resize(ref cinsiyetler, cinsiyetler.Length + 1);
                cinsiyetler[i] = Convert.ToChar(Console.ReadLine());

                Console.WriteLine($"{i + 1}. ögreci Tc: ");
                Array.Resize(ref tcler, tcler.Length + 1);
                tcler[i] = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"{i + 1}. ögreci kiosu: ");
                Array.Resize(ref kilolar, kilolar.Length + 1);
                kilolar[i] = Convert.ToDouble(Console.ReadLine());

                sayac++;

                if (sayac % 10 == 0)

                {
                    for (int j = sayac - 10; j < sayac; j++)
                    {
                        Console.WriteLine($"{j + 1}. Öğrenci Adı: {isimler[j]} \\  Soyadı: {soyİsimler[j]} \\ Doğum Tarihi: {dogumTarihleri[j]}\\ Cinsiyeti: {cinsiyetler[j]} \\  TC: {tcler[j]} \\  Kilosu: {kilolar[j]} kg ");
                    }


                }



            }
        }


        // Metot Örnek 9: Klavyeden kullanıcı tarafından girilen iki sayıdan büyük olanı metot içinde bulup sonucu ana metotta ekrana yazdıran programı yazınız.
        static void Enbuyuk()
        {

            bool sonuc1, sonuc2 = true;
            int sayi1, sayi2;
            do
            {
                Console.WriteLine("Lütfen bir tam sayı giriniz.");
                sonuc1 = int.TryParse(Console.ReadLine(), out sayi1);
                Console.WriteLine("Lütfen ikinci bir tam sayı giriniz.");
                sonuc2 = int.TryParse(Console.ReadLine(), out sayi2);

                if (!sonuc1 && !sonuc2)
                    Console.WriteLine("Hatalı giriş yaptınız.");
                else if (sayi1 > sayi2)

                    Console.WriteLine($"Girdiğiniz iki sayıdan en büyüğü {sayi1}'dir. ");

                else if (sayi2 > sayi1)

                    Console.WriteLine($"Girdiğiniz iki sayıdan en büyüğü {sayi2}'dir. ");


            } while (!sonuc1 && sonuc2);




        }
        //static void TekCift(int sayi)

        //{


        //    if (sayi % 2 == 0)
        //    {
        //        Console.WriteLine($"{sayi} sayısı Çift.");
        //    }

        //    else
        //    {
        //        Console.WriteLine($"{sayi} sayısı Tek.");
        //    }

        //}


        //static int ToplamKup(int sayi1, int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;

        //    return toplam * toplam * toplam;
        //}
        static int KullanıcıdanTamSayiDegeriAl()
        {
            bool sonuc = true;
            int sayi;
            do
            {
                Console.WriteLine("Lütfen birtam sayı giriniz.");
                sonuc = int.TryParse(Console.ReadLine(), out sayi);

                if (!sonuc)
                    Console.WriteLine("Hatalı giriş yaptınız.");

            } while (!sonuc);
            return sayi;
        }

        //static int BirIleSayi(int sayi)
        //{
        //    for (int i = 1; i <= sayi; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //static void BirIleYuz()
        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //static int KareAl(int sayi)
        //{
        //    return sayi*sayi;

        //}

        //static int Carpma(int sayi1, int sayi2)
        //{
        //    return sayi1*sayi2;

        //}

        //static int Toplama(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;

        //}

        //static void Yaz()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{i+1}.BilgeAdam");
        //    }
        //}

        //static void EkranaYaz(string gelenDeger1, string gelenDeger2, string gelenDeger3)
        //{
        //    Console.WriteLine("Parametre olarak sırasıyla gelen değerler: {0} {1} {2}", gelenDeger1, gelenDeger2, gelenDeger3);
        //}


        //static void Selamla(string metin ="Dostum")

        //{
        //    //if (string.IsNullOrWhiteSpace(metin))
        //    //{
        //    //    Console.WriteLine("Merhaba Dostum");

        //    //}


        //    //else

        //        Console.WriteLine($"Merhaba {metin}");






        //}

        //static int ToplamaYap6(int sayi1, int sayi2, int sayi3)
        //{

        //    return sayi1 + sayi2 + sayi3;

        //}
        //static string ToplamaYap5(float sayi1, float sayi2)
        //{

        //    float toplam = sayi1 + sayi2;
        //    return "Toplam : " + toplam;
        //}


        //// parametre alan geriye değer döndüren metotlar
        //static int ToplamaYap4(int sayi1, int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;
        //    return toplam;


        //}
        //// parametre alan geriye değer döndürmeyen metotlar
        //static void ToplamaYap3(int sayi1, int sayi2)

        //{

        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine("Girilen 2 sayının toplamı: " + toplam);
        //}

        //// parametre almayan geriye değer döndüren metotlar
        //static int ToplamaYap2()
        //{
        //    int sayi1, sayi2;
        //    sayi1 = 15;
        //    sayi2 = 25;
        //    int toplam = sayi1 + sayi2;
        //    return toplam; // RETURN ÜN YANINDA YAZAN DEĞERİN TİPİ İLE METODUN SOLUNDA YAZAN GERİ DÖNÜŞ TİPİNİN AYNI OLMASI GEREKİYOR.


        //}

        //// parametre alamayan geriye değer döndürmeyen metot
        //static void ToplamaYap1()
        //{
        //    int sayi1, sayi2;

        //    sayi1 = 15;
        //    sayi2 = 24;
        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine(toplam);
        //}


    }

}


// 
