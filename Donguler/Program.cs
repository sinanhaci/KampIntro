using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "yazılım gelişirici yetiştirme kampı";
            //string kurs2 = "programlamaya başlangıç için temel kurs";
            //string kurs3 = "java";
            //string kurs4 = "Phyton";
            //string kurs5 = "C++";

            //array - dizi

            //string[] kurslar = new string[] { "yazılım gelişirici yetiştirme kampı","programlamaya başlangıç için temel kurs","java", 
            //   "Phyton","C++" };


            //for (int i = 0; i < kurslar.Length; i++)  //kurslar.length= eleman sayısı       //i++  = 1er artıyor //i=i+2, i+=2  =   2şer artıyor
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            //Console.WriteLine("For bitti");


            // foreach (string kurs in kurslar)
            //{
            //    Console.WriteLine(kurs);
            //}

            //Console.WriteLine("Sayıyı girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string islem = (sayi % 2 == 0) ? "bölünüyor" : "bölünmüyor";
            //Console.WriteLine(islem);
            Console.WriteLine("sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("sayı 2 ye bölünüyor");
            }
            else
            {
                Console.WriteLine("sayı 2 ye bölünmüyor");
            }
        }
    }
}
