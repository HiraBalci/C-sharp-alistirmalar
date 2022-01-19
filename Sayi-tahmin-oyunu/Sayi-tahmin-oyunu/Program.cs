using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayi_tahmin_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
        b:
            int hak = 5;
            int tur = 1;

            int kullanici_rakamı;
            float puan = 100 / tur;
            int tutulan = (new Random()).Next(1, 50);
            Console.WriteLine($"Sayı tahmin oyununa hoşgeldiniz!");
            Console.WriteLine($"Bilgisayarın 1 -50 arası tuttuğu rastgele sayıyı bulmaya çalışın.Size 5 hak sunulmaktadır.");
            if (hak == 5)
            {
                Console.WriteLine($"{hak - 4}.Hakkınız,lütfen rakamı tahmin ediniz:");
                kullanici_rakamı = int.Parse(Console.ReadLine());
                if (kullanici_rakamı == tutulan)
                {
                    Console.WriteLine($"Tebrikler sayıyı bildiniz!");
                    Console.WriteLine($"Puanınız {puan}");
                    goto a;
                }
                if (kullanici_rakamı < tutulan)
                {
                    Console.WriteLine($"Lütfen daha yüksek değerli bir rakam giriniz.");
                    hak--;
                    tur++;

                }
                if (kullanici_rakamı > tutulan)
                {
                    Console.WriteLine($"Lütfen daha düşük değerli bir rakam giriniz.");
                    hak--;
                    tur++;

                }


            }
            if (hak == 4)
            {
                Console.WriteLine($"{hak - 2}.Hakkınız,lütfen rakamı tahmin ediniz:");
                kullanici_rakamı = int.Parse(Console.ReadLine());
                if (kullanici_rakamı == tutulan)
                {
                    puan = 100 / tur;
                    Console.WriteLine($"Tebrikler sayıyı bildiniz!");
                    Console.WriteLine($"Puanınız {puan}");
                    goto a;
                }
                if (kullanici_rakamı < tutulan)
                {
                    Console.WriteLine($"Lütfen daha yüksek değerli bir rakam giriniz.");
                    hak--;
                    tur++;

                }
                if (kullanici_rakamı > tutulan)
                {
                    Console.WriteLine($"Lütfen daha düşük değerli bir rakam giriniz.");
                    hak--;
                    tur++;

                }


            }
            if (hak == 3)
            {
                Console.WriteLine($"{hak}.Hakkınız,lütfen rakamı tahmin ediniz:");
                kullanici_rakamı = int.Parse(Console.ReadLine());
                if (kullanici_rakamı == tutulan)
                {
                    puan = 100 / tur;
                    Console.WriteLine($"Tebrikler sayıyı bildiniz!");
                    Console.WriteLine($"Puanınız {puan}");
                    goto a;
                }
                if (kullanici_rakamı < tutulan)
                {
                    Console.WriteLine($"Lütfen daha yüksek değerli bir rakam giriniz.");
                    hak--;
                    tur++;

                }
                if (kullanici_rakamı > tutulan)
                {
                    Console.WriteLine($"Lütfen daha düşük değerli bir rakam giriniz.");
                    hak--;
                    tur++;

                }


            }
            if (hak == 2)
            {
                Console.WriteLine($"{hak + 2}.Hakkınız,lütfen rakamı tahmin ediniz:");
                kullanici_rakamı = int.Parse(Console.ReadLine());
                if (kullanici_rakamı == tutulan)
                {
                    puan = 100 / tur;
                    Console.WriteLine($"Tebrikler sayıyı bildiniz!");
                    Console.WriteLine($"Puanınız {puan}");
                    goto a;
                }
                if (kullanici_rakamı < tutulan)
                {
                    Console.WriteLine($"Lütfen daha yüksek değerli bir rakam giriniz.");
                    hak--;
                    tur++;

                }
                if (kullanici_rakamı > tutulan)
                {
                    Console.WriteLine($"Lütfen daha düşük değerli bir rakam giriniz.");
                    hak--;
                    tur++;

                }


            }
            if (hak == 1)
            {
                Console.WriteLine($"Sonuncu hakkınız,lütfen rakamı tahmin ediniz:");
                kullanici_rakamı = int.Parse(Console.ReadLine());
                if (kullanici_rakamı == tutulan)
                {
                    puan = 100 / tur;
                    Console.WriteLine($"Tebrikler sayıyı bildiniz!");
                    Console.WriteLine($"Puanınız {puan}");
                    goto a;
                }
                if (kullanici_rakamı < tutulan)
                {
                    Console.WriteLine($"Oyunu kaybettiniz.Puanınız 0'dır.");
                    goto a;
                }
                if (kullanici_rakamı > tutulan)
                {
                    Console.WriteLine($"Oyunu kaybettiniz.Puanınız 0'dır.");
                    goto a;

                }


            }
        a:
            Console.WriteLine($"Oyun bitti tekrar oynamak ister misiniz?(evet/hayır)");
            string cevap = Console.ReadLine();
            if (cevap == "evet" || cevap == "e")
            {
                goto b;
            }
        }
    }
}
