using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool asalmi=true;
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int asal =int.Parse(Console.ReadLine());
            if (asal == 0 && asal<0)
            {
                Console.WriteLine("Girdiğiniz sayı geçerli değildir.");
            }
            else if(asal==1 || asal == 2)
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
            }
            else if (asal>2)
            {
                for(int i=2;i<asal;i++)
                {
                    if (asal % i == 0)
                    {
                        asalmi = false;
                        break;
                    }

                  
                   
                }
                
            }
            if (asalmi)
            {
                Console.WriteLine("Sayı asal.");
            }
            else
            {
            
                Console.WriteLine("Sayı asal değildir.");
            }
            

        }
    }
}
