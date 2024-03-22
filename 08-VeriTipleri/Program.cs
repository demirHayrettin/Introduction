// Değişken: içerisinde değer tutan depolarımız olarak adlandırılabilir. İçinde tutulacak değere göre veri tipi seçilmelidir. Örneğin; 81 ilin plaka kodlarını tutmak istiyorsak, byte türünde bir değişken tanımlayabilirim.

// byte 0 ile 255 arasında 256 tane değer alır.2^8 = 256
// 8 bit 1 byte 
byte plakaKodu = 81;

plakaKodu = 35;

plakaKodu = 255;

//plakaKodu = -1;
//plakaKodu = 256;

sbyte sby; // -128 ile 127 arasında

// -32767 ile 32767 arasındaki sayılar için short veri tipi kullanılabilir. 2^16 = 665536. 2 byte
short kisaVeritipi;

kisaVeritipi = 32767;

ushort isaretsizKisaVeritipi; // 0 - 65536

int sayi; // MinValue = -2147483648; MaxValue = 2147483647;

uint isaretsizSayi; // 0 ile MaxValue = 4294967295;2^32 32/8 4 byte.

// isaretsizSayi = -1; hata verir

long buyukSayi;  // MinValue = -9223372036854775808;MaxValue = 9223372036854775807;

ulong isaretsizBuyukSayi; // 0 ile MaxValue = 18446744073709551615; 2^64 : 8 byte.

//int.MaxValue;
//int.MinValue;

double doubleOndalikliSayi = 1.2; // Ondalikli sayıları tutuyor.

doubleOndalikliSayi = 7777777777777777777777777777764444d;

decimal decimalOndalikliSayi = 445658155456456442222222225.2M;


string kelime = "hasret";

kelime = "Boost Yıldız Yazılımcı Programi";

//char karekter = "a"; HATA VERİR

char karakter = 'a';

