﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naning convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urunAdi);
        }


    
    
    
    
    }


}
