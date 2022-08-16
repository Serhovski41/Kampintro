using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.SurName + " : " + musteri.AccountNumber + " = " + "Musteri  Eklendi!");
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.SurName + " : " + musteri.AccountNumber + " = " + "Musteri Listelendi!");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.SurName + " : " + musteri.AccountNumber + " = " + "Musteri Silindi!");
        }
    }
}
