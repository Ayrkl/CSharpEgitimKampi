using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else If Else

            //Console.WriteLine("Lütfen şifreyi giriniz");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abc")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;

            //Console.Write("Lütfen bir şehir giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Lütfen bir ülke giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veri Doğrulandı");
            //}else
            //{
            //    Console.WriteLine("Veri Yanlış");
            //}

            //int number;

            //Console.Write("Lütfen bir sayı giriniz: ");
            //number= int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine("Sayı pozitif");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("Sayı negatif");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı sıfırdır");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Başarısız";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Başarılı";
            //}
            //if (average > 70 & average <= 85)
            //{
            //    result = "Çok Başarılı";
            //}
            //if (average > 85 & average <= 100)
            //{
            //    result = "Mükemmel";
            //}

            //Console.WriteLine("Sonuç: " + result);

            //string city;
            //Console.WriteLine("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "istanbul" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Türkiye'de");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Türkiye'de değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz : ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilir");
            //}
            //else 
            //{ 
            //    Console.Write("bu kullanıcı adı kabul edilemez");

            //}


            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 10;
            //int result = number % 2;

            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1  % number2; 

            //Console.WriteLine("Mod işleminin sonucu: " + result);

            #endregion

            #region Değişkenler ile karar yapıları

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tek");
            //}

            //char team;
            //Console.Write("Lütfen bir takım giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış takım girdiniz");
            //}

            #endregion

            #region Örnek  Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim kampı restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //Console.WriteLine("1. Hamburger");
            //Console.WriteLine("2. Pizza");
            //Console.WriteLine("3. Salata");
            //Console.WriteLine("-------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Lütfen detayını görmek istediğiniz menü seçimi:");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Hamburger Menüler -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Double Burger");
            //    Console.WriteLine("2. Az Burger");
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Hamburger Menüler -------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Pizza Menüler -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Margarita");
            //    Console.WriteLine("2. Sucuklu");
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Pizza Menüler -------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Salata Menüler -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Akdeniz Salata");
            //    Console.WriteLine("2. Tavuk Salata");
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Salata Menüler -------------");
            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen bir ay giriniz: ");
            //int monthNumber;
            //monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış ay girdiniz");
            //        break;
            //}


            #endregion

            #region Hesap Makinesi Switch Case

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen işlem sembolünü giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{ 
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplama işlemi sonucu: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma işlemi sonucu: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma işlemi sonucu: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme işlemi sonucu: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış işlem girdiniz");
            //        break;
            //}

            #endregion

            Console.Read();

        }
    }
}
