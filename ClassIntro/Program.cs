using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Sinan";
            int yas = 26;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 25;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Phyton";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOrani = 61;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Engin ";
            kurs3.IzlenmeOrani = 55;



            //Console.WriteLine(kurs1.Egitmen + " - " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + " - " + kurs.KursAdi);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
