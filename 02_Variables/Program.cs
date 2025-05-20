using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dobule Değişkenler
            //double number;

            //number = 4.5;
            //Console.WriteLine(number);
            #endregion

            #region Dobule Değişkenler V2
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine("");

            //double applePrice , oragePrice , bananaPrice , watermelonPrice , grapePrice;

            //applePrice = 10.5;
            //oragePrice = 12.5;
            //bananaPrice = 8.5;
            //watermelonPrice = 15.5;
            //grapePrice = 20.5;

            //Console.WriteLine("---- Elma Birim Fiyatı " + applePrice + " TL ----");
            //Console.WriteLine("---- Portakal Birim Fiyatı " + oragePrice + " TL ----");
            //Console.WriteLine("---- Muz Birim Fiyatı " + bananaPrice + " TL ----");
            //Console.WriteLine("---- Karpuz Birim Fiyatı " + watermelonPrice + " TL ----");
            //Console.WriteLine("---- Üzüm Birim Fiyatı " + grapePrice + " TL ----");

            //double appleGram, orageGram , bananaGram , watermelonGram , grapeGram;
            //appleGram = 1.245;
            //orageGram = 2.450;
            //bananaGram = 1.650;
            //watermelonGram = 3.090;
            //grapeGram = 2.350;

            //double appleTotalPrice = appleGram * applePrice;
            //double orageTotalPrice = orageGram * oragePrice;
            //double bananaTotalPrice = bananaGram * bananaPrice;
            //double watermelonTotalPrice = watermelonGram * watermelonPrice;
            //double grapeTotalPrice = grapeGram * grapePrice;

            //Console.WriteLine("");
            //Console.WriteLine("-Alınan Ürün: Elma " + " -Birim Fiyatı:" + applePrice + " -Gramaj: " + appleGram + " -Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("-Alınan Ürün: Portakal " + " -Birim Fiyatı:" + oragePrice + " -Gramaj: " + orageGram + " -Toplam Tutar: " + orageTotalPrice);
            //Console.WriteLine("-Alınan Ürün: Muz " + " -Birim Fiyatı:" + bananaPrice + " -Gramaj: " + bananaGram + " -Toplam Tutar: " + bananaTotalPrice);
            //Console.WriteLine("-Alınan Ürün: Karpuz " + " -Birim Fiyatı:" + watermelonPrice + " -Gramaj: " + watermelonGram + " -Toplam Tutar: " + watermelonTotalPrice);
            //Console.WriteLine("-Alınan Ürün: Üzüm " + " -Birim Fiyatı:" + grapePrice + " -Gramaj: " + grapeGram + " -Toplam Tutar: " + grapeTotalPrice);

            //double totalPrice = appleTotalPrice + orageTotalPrice + bananaTotalPrice + watermelonTotalPrice + grapeTotalPrice;
            //Console.WriteLine("");
            //Console.Write("Alışveriş Toplam Tutarı: " + totalPrice);
            #endregion


            #region char Değişkenler

            //ABCDEFGH
            //TOPLANTI SAAT 20:00'DE

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri girişleri string değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine("");

            //string passengerName ,passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();



            //Console.Write("");
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Yolcu TC Kimlik No" + passengerIdentityNumber + "Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam sayı Girişi ve Dönüşümler

            //ABC12D

            //int shoePrice, computerPrice, phonePrice, tabletPrice;

            //shoePrice = 1000;
            //computerPrice = 5000;
            //phonePrice = 3000;
            //tabletPrice = 2000;

            //int shoeCount, computerCount, phoneCount, tabletCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı sayısını giriniz : ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Telefon sayısını giriniz : ");
            //phoneCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Tablet sayısını giriniz : ");
            //tabletCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + phoneCount * phonePrice + tabletCount * tabletPrice;

            //Console.WriteLine("------------------");
            //Console.WriteLine("Alışveriş Toplam Tutarı: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklık Giriş ve Dönüşümler


            //double exam1, exam2, exam3, exam4, exam5, result;

            //Console.WriteLine("***** Öğrenci Notları *****");

            //Console.Write("Lütfen 1.sınav notunu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 4.sınav notunu giriniz:");
            //exam4 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 5.sınav notunu giriniz:");
            //exam5 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3 + exam4 + exam5) / 5;

            //Console.WriteLine("------------------");
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender; 
            //Console.Write("Lütfen Cinsiyetinizi giriniz (E/K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyet: "+ gender);

            #endregion

            Console.Read();
        }
    }
}
