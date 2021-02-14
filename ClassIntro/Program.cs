using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Tarlan";
            int yas = 22;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Tarlan";
            kurs1.IzlemeOranı = 68;         
            Console.WriteLine("Hello World!");

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ahmet";
            kurs2.IzlemeOranı = 64;
            Console.WriteLine("Hello World!");

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlemeOranı = 61;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen + " " + kurs.IzlemeOranı);
            }
           





            Console.WriteLine("Hello World!");
        }
    }


    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemeOranı { get; set; }
    }
}
