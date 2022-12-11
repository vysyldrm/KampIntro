using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazilim gelistirici yetistirme kampı", 
                "Programlamaya baslangic icin temel kurs",
                "Java", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n*****\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu.");
        }
    }
}
