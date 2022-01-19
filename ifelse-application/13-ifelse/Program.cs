using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Kullanıcıdan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme 
            // durumunu kontrol ediniz. Ehliyet alma koşulu en az 18 ve eğitim durumu 
            // lise ya da üniversite olmalıdır.
            Console.WriteLine($"Ehliyet sınavına girecek olan kişinin adını giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine($"Ehliyet sınavına girecek olan kişinin yaş bilgisini giriniz:");
            int yas =int.Parse(Console.ReadLine());
            Console.WriteLine($"Ehliyet sınavına girecek olan kişinin eğitim bilgisini giriniz:");
            string egitim = Console.ReadLine();
            if (yas >= 18 && (egitim == "lise" || egitim == "üniversite"))
            {
                Console.WriteLine($"{isim} adındaki kişi ehliyet sınavına girebilir.");
            }else if(yas< 18 && (egitim == "lise" || egitim == "üniversite")) {
                        Console.WriteLine($"{isim} adındaki kişi eğitim kriterini sağlar fakat yaşından ehliyet sınavına ötürü sınava giremez");
    }
            else if (yas >= 18 && (egitim!=("lise")|| egitim!=("üniversite")))
            {
                Console.WriteLine($"{isim} adındaki kişi yaş kriterini sağlar fakat eğitim durumundan ötürü ehliyet sınavına giremez");
            }
            else if (yas < 18 && egitim != ("lise") || egitim != ("üniversite"))
            {
                Console.WriteLine($"{isim} adındaki kişi yaşı {yas} ve eğitim durumu {egitim} olduğundan ötürü sınava giremez.");
            }
            //2-Girilen üç sayının en büyüğünü bulunuz.
            Console.WriteLine("Lütfen 1.değeri giriniz:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.değeri giriniz:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 3.değeri giriniz:");
            double c = double.Parse(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine($"{a} sayısı en büyük sayıdır.");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine($"{b} sayısı en büyük sayıdır.");
            }
            else if (c > b && c > a)
            {
                Console.WriteLine($"{c} sayısı en büyük sayıdır.");
            }
            else if (c ==b && c == a && b==a)
            {
                Console.WriteLine($"{a},{b} ve {c} sayıları birbirine eşittir.");
            }

            // 3- Bir öğrencinin 2 yazılı bir sözlü notunu alıp hesaplanan ortalamaya göre
            // not aralığına karşılık gelen not bilgisini yazdırınız.
            // 0 -24  => 0
            // 25-44  => 1
            // 45-54  => 2
            // 55-69  => 3
            // 70-84  => 4
            // 85-100 => 5
            Console.WriteLine("Lütfen 1.notu giriniz:");
            int not1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.notu giriniz:");
            int not2 = int.Parse(Console.ReadLine());
            float ortalama = (not1 + not2) / 2;
            if(ortalama<=24 || ortalama==0 )
            {
                Console.WriteLine($"Öğrencinin not bilgisi 0'dır.");
            }
            else if (ortalama >= 25 && ortalama <=44)
            {
                Console.WriteLine($"Öğrencinin not bilgisi 1'dir.");
            }
            else if (ortalama >= 45 && ortalama <= 54)
            {
                Console.WriteLine($"Öğrencinin not bilgisi 2'dir.");
            }
            else if (ortalama >= 55 && ortalama <= 69)
            {
                Console.WriteLine($"Öğrencinin not bilgisi 3'dir.");
            }
            else if (ortalama >= 70 && ortalama <= 84)
            {
                Console.WriteLine($"Öğrencinin not bilgisi 4'dir.");
            }
            else if (ortalama >= 85 && ortalama <= 100)
            {
                Console.WriteLine($"Öğrencinin not bilgisi 5'tir.");
            }else
            {
                Console.WriteLine("Değerler geçersizdir.");
            }
        }
    }
}
