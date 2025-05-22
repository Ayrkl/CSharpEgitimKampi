using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;

            //for(i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //int finishValue= int.Parse(Console.ReadLine());

            //for(int i =1; i <=finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}




            #endregion

            #region For Döngüsü ile karar yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if(i % 5 == 0 )
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue= 0;

            //for(int i = 1; i <= 10; i++)
            //{
            //  totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;

            //for(int i = 1; i < 20; i++)
            //{
            //   if(i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------------------");
            //Console.WriteLine(totalvalue);

            //int count = 0;

            //for(int i = 1 ; i <= 50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            //int bakterium = 1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bakterium *= 2;
            //    Console.WriteLine(i+".saatin sonunda" +bakterium);
            //}




            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 5)
            //{
            //    Console.WriteLine("Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{ 
            //  if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i  = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}   
            //Console.WriteLine(sum);





            #endregion

            #region Örnek Sınav Sorusu

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //int number = int.Parse(Console.ReadLine());

            //int ones,tens,hundreds;
            //int sum;

            //ones = number / 100; // 1ler basamağı
            //tens = (number / 10) % 10; // 10lar basamağı
            //hundreds = (number % 100) % 10; // 10'lar basamağına geçiş


            //Console.WriteLine(ones +"--" +tens +"--"+ hundreds);

            //sum = ones + tens + hundreds;
            //Console.WriteLine("Toplam: " + sum);



            #endregion

            Console.Read();
        }
    }
}
