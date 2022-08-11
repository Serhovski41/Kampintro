using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.65;
            double dolarBugün = 7.65;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Azalış butonu");
            }           
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            
        }
    }
}
