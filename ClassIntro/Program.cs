using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs(); // class ın değişkenlerini özelliklerini atamasını burdan yapacağım
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;


            Kurs kurs2 = new Kurs(); // kurs2 yazmak yerine istediğimizi yazabiliriz sadece anlamlı olsun
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem vaarış";
            kurs2.İzlenmeOrani = 69;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.İzlenmeOrani = 78 ;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

        }
    }

   class tanımlamak için bunu yazacağız ama öelliklerini yukarıdaki kısımdan yapacağız
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int  İzlenmeOrani{ get; set; }





    }
}
