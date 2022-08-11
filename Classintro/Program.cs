using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Kiyafet kiyafet1 = new Kiyafet();
            kiyafet1.KiyafetAdi = "T-shirt";
            kiyafet1.cins = "koton";
            kiyafet1.renk = "mavi";

            Kiyafet kiyafet2 = new Kiyafet();
            kiyafet2.KiyafetAdi = "pantolon";
            kiyafet2.cins = "keten";
            kiyafet2.renk = "yeşil";

            Kiyafet kiyafet3 = new Kiyafet();
            kiyafet3.KiyafetAdi = "etek";
            kiyafet3.cins = "pamuklu";
            kiyafet3.renk = "kırmızı";


            Kiyafet[] kiyafetler = new Kiyafet[] { kiyafet1, kiyafet2, kiyafet3 };

            foreach (var Kiyafet in kiyafetler)
            {
                Console.WriteLine(Kiyafet.KiyafetAdi + " : " + Kiyafet.cins + " : " + Kiyafet.renk );
            }

        }
    }

    class Kiyafet
    {
        
        public string KiyafetAdi { get; set; }
        public string cins { get; set; }

        public string renk { get; set; }
    }
}
