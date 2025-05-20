using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            //Console.WriteLine("selam");
            //Console.Write("Merhaba dünya");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine("");
            //Console.WriteLine("1. Kahvaltılık");
            //Console.WriteLine("2. Ana Yemekler");
            //Console.WriteLine("3. Soğuk Yemekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region string Değişkenler

            //string customerName;
            //string customerNameSurname;
            //string customerNumber;
            //string customerEmail , district , city;

            //customerName = "ahmet";
            //customerNameSurname = "yılmaz";
            //customerNumber = "123456";
            //customerEmail = "sdads@gmail.com";
            //district = "Küçükçekmece";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine("");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerNameSurname);
            //Console.WriteLine("Müşteri No:" + customerNumber);
            //Console.WriteLine("E-posta:" + customerEmail);
            //Console.WriteLine("İlçe:" + district + "/" + city);
            //Console.WriteLine("----------------------------------");

            //customerName = "ahmet";
            //Console.WriteLine(customerName);

            #endregion

            #region int Değişkenler

            int hamburgerPrice = 50;
            int cokePrice = 20;
            int frenchFriesPrice = 15;
            int pizzaPrice = 80;
            int lemonadePrice = 10;

            Console.WriteLine("***** Menü *****");
            Console.WriteLine("");
            Console.WriteLine("1. Hamburger:" + hamburgerPrice + " TL");
            Console.WriteLine("2. Pizza:" + pizzaPrice + " TL");
            Console.WriteLine("3. Kola:" + cokePrice + " TL");
            Console.WriteLine("4. Patates Kızartması:" + frenchFriesPrice + " TL");
            Console.WriteLine("5. Limonata:" + lemonadePrice + " TL");
            Console.WriteLine("");
            Console.WriteLine("****************");

            Console.WriteLine("");
            Console.WriteLine("***** Restorant Menü Fiyatı *****");
            Console.WriteLine("");
            int hamburgerCount;
            int pizzaCount;
            int cokeCount;
            int frenchFriesCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalPizzaPrice = 0;
            int totalCokePrice = 0;
            int totalFrenchFriesPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 5;
            pizzaCount = 2;
            cokeCount = 3;
            frenchFriesCount = 5;
            lemonadeCount = 4;
            totalHamburgerPrice = hamburgerCount*hamburgerPrice;
            totalPizzaPrice = pizzaCount*pizzaPrice;
            totalCokePrice = cokeCount*cokePrice;
            totalFrenchFriesPrice = frenchFriesCount*frenchFriesPrice;
            totalLemonadePrice = lemonadeCount*lemonadePrice;


            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + "TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + "TL");
            Console.WriteLine("Patates Kızartması Tutarı:" + totalFrenchFriesPrice + "TL");
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + "TL");
            Console.WriteLine("Toplam Tutar:" + (totalHamburgerPrice + totalPizzaPrice + totalCokePrice + totalFrenchFriesPrice + totalLemonadePrice) + "TL");





            #endregion
            Console.Read();

        }
    }
}
