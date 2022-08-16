using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Serhat";
            musteri1.SurName = "Ozdemir";
            musteri1.Id = 12345;
            musteri1.AccountNumber = 10;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Engin";
            musteri2.SurName = "Toprak";
            musteri2.Id = 23456;
            musteri2.AccountNumber = 11;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Ugurcan";
            musteri3.SurName = "Kurt";
            musteri3.Id = 34567;
            musteri3.AccountNumber = 12;

            Musteri[] musteriler = new Musteri[]
            {
                musteri1, musteri2, musteri3
            };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.SurName + " : " + musteri.Id + " : " + musteri.AccountNumber);
            }

            Console.WriteLine("-----------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri3);
        }
    }
}
