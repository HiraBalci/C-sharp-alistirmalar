using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayac = 1;
            //Console.WriteLine("Lütfen ürün adedini giriniz:");
            //int adet = int.Parse(Console.ReadLine());
            //int[] sayilar=new int[adet];
            //for(int index = 0; index <= sayilar.Length - 1; index++)
            //{

            //   sayilar[index] =(int)adet;
            //    adet = adet - 1;
            //    Console.WriteLine($"arrayin {sayac}.eleman değeri {sayilar[index]}dır");
            //    sayac++;
            //}
            Console.WriteLine("Lütfen ürün adedini giriniz:");
            int adet = int.Parse(Console.ReadLine());
           string urun = null;
            string[] dizi = new string[adet];
            int sayac = 1;
            int i = 0;
            
            do {
                Console.WriteLine("Lütfen ürün adını giriniz:");
                urun = Console.ReadLine();
                dizi[i] = urun;
                i++;
            } while (i < adet);
            Console.WriteLine("ürünler listeniyor...");
            for(int a=0; a <=(dizi.Length) - 1; a++)
            {
                
                Console.WriteLine($"dizinin {sayac}. elemanı {dizi[a]}. ");//eğer ben buraya urun yazarsam son urun yazdığım şeyi listeler...
                sayac++;
            }
        }
    }
}
