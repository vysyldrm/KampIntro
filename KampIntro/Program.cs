using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if(dolarDun > dolarBugun) 
            {
                System.Console.WriteLine("Azalis Butonu.");
            }
            else if (dolarDun < dolarBugun)
            {
                System.Console.WriteLine("Artis Butonu");
            }
            else
            {
                System.Console.WriteLine("Degismedi Butonu.");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu.");
            }
            else
            {
                Console.WriteLine("Giris yap butonu.");
            }

            System.Console.WriteLine(kategoriEtiketi);
        }
    }
}
