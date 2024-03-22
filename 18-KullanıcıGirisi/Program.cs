int pasword;
string kullaniciAdi;

Console.WriteLine("Kullanıcı adınızı giriniz");
kullaniciAdi = Console.ReadLine();

Console.WriteLine("Kullanıcı şifrenizi giriniz");

pasword = Convert.ToInt32(Console.ReadLine());

if (kullaniciAdi == "admin" || kullaniciAdi == "Admin" && pasword == 1234)
    
    Console.WriteLine("Giriş Başarılı");

else

    Console.WriteLine("Hatalı kullanıcı adı veya şifre girdiniz");
