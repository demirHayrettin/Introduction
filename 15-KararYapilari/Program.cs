// Kullanıcıdan alınan iki sayıdan önce girilen mi daha büyük, sonra girilen mi daha büyük, sonucu bulan ve ekrana yazan program...

/*
 * 1. Adım: Başla
 * 2. Adım: Kullanıcıdan sayi1 ve sayi2 değerlerini al
 * 3. Adım: Eğer sayi1 > sayi2 ise Ekrana Yaz ("1. girilen sayı daha büyüktür")
 * 4. Adım: Eğer sayi2 > sayi1 ise Ekrana Yaz("2. girilen sayı daha büyüktür")
 * 5. Adım: Eğer sayi1 == sayi2 ise Ekrana Yaz("Girilen iki sayı birbirine eşittir")
 * 6. Adım: Bitir
 */

using System;

Console.WriteLine("Lütfen 1. Sayıyı giriniz");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Lütfen 2. Sayıyı giriniz");
double sayi2 = Convert.ToDouble(Console.ReadLine());

//if (sayi1 > sayi2)
//    Console.WriteLine(" 1. girilen sayı daha büyüktür. ");

//else if (sayi2 > sayi1)
//    Console.WriteLine(" 2. Girilen sayı daha büyüktür. ");

//else
//    Console.WriteLine(" Girilen iki sayı birbirine eşittir. ");



if (sayi1 > sayi2)
    Console.WriteLine(" 1. girilen sayı daha büyüktür. ");

if (sayi2 > sayi1)
    Console.WriteLine(" 2. Girilen sayı daha büyüktür. ");

if (sayi1 == sayi2)
    Console.WriteLine(" Girilen iki sayı birbirine eşittir. ");