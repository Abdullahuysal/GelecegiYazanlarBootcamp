using System;
using System.Collections.Generic;

namespace Odev1
{
    class Program
    {
        static List<string> model = new List<string> { "mercedes", "tesla", "bmw", "bentley", "audi", "bugatti", "porsche", "toyota" };
        static List<string> aylar = new List<string> { "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık" };
        
        static bool Find(string marka)
        {
            bool deger = model.Contains(marka);
            if (deger)
            {
                return true;
            }
            return false;
        }
        static void Add(string marka)
        {
            model.Add(marka);
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Marka aramak için=> 1");
                Console.WriteLine("Marka eklemek için=> 2");
                Console.WriteLine("Tarihi görmek için=>3 giriniz");
                Console.WriteLine("Çıkış yapmak için=>4 giriniz");
                int secenek = Convert.ToInt32(Console.ReadLine());
                switch (secenek)
                {
                    case 1:
                        {
                            Console.WriteLine("Aramak istediğiniz araba markasını giriniz");
                            string marka = Console.ReadLine().ToLower();
                            bool bulundumu = Find(marka);
                            if (bulundumu)
                            {
                                int index = model.IndexOf(marka) + 1;
                                Console.WriteLine("listede " + index + ". Sırada bulunmaktadır.");
                            }
                            continue;
                        }
                    case 2:
                        {
                            Console.WriteLine("Eklemek istediğiniz markayı giriniz");
                            string marka = Console.ReadLine().ToLower();
                            Add(marka);
                            Console.WriteLine("Marka eklendi Tüm markalar:");
                            foreach (var item in model)
                            {
                                Console.WriteLine(item);
                            }
                            continue;
                        }
                    case 3:
                        {
                            string tarih = DateTime.Now.ToString();
                            string[] splittarih = tarih.Split('/');
                            string ay = aylar[Convert.ToInt32(splittarih[0])];
                            Console.WriteLine("bugün "+splittarih[1]+""+ay+""+splittarih[2]);

                            continue;
                        }
                    case 4:
                        {
                            Console.WriteLine("Programdan çıkılıyor");

                            break;
                        }
                    default:
                        break;
                }
                return;

            }
           
            

            
            

        }
    }
}
