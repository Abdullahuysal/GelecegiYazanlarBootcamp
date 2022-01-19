using System;
using System.Collections.Generic;

namespace Odev1
{
    class Program
    {
        static List<string> model = new List<string> { "mercedes", "tesla", "bmw", "bentley", "audi", "bugatti", "porsche", "toyota" };
        static bool Find(string marka)
        {
            bool deger = model.Contains(marka);
            if (deger)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Aramak istediğiniz modeli giriniz");
            string marka = Console.ReadLine();
            bool bulundumu = Find(marka);

            if (bulundumu)
            {
                int index = model.IndexOf(marka) + 1;

                Console.WriteLine("listede " + index + ". Sırada bulunmaktadır.");
                Console.WriteLine("Tüm markalar:");

                foreach (var item in model)
                {
                    Console.WriteLine(item);
                }
            }
            string tarih = DateTime.Now.ToString();
            string[] splittarih = tarih.Split(':');
            string[] ay = splittarih[0].Split('/');
            Console.WriteLine("bugün ayın " + ay[1] + "'u");

        }
    }
}
