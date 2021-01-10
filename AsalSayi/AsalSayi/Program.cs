using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilenSayi = 0;
            

            List<int> asalSayilar = new List<int>();
            Console.WriteLine("2 ile hangi sayı arasındaki asal sayıları bulayım senin için?");

            if (int.TryParse(Console.ReadLine(), out girilenSayi))
            {
                for (int i = 3; i <= girilenSayi; i++)
                {
                    bool asalMi = true;
                    for (int bolen = 2; bolen < i; bolen++)
                    {
                        if (i % bolen == 0)
                        {
                            asalMi = false;
                            break;
                        }
                    }
                    if (asalMi)
                    {
                        asalSayilar.Add(i);
                    }
                }
            }
            Console.WriteLine("Buldum :)");

            foreach (int sayi in asalSayilar)
            {
                Console.Write(sayi + " ");
            }


            Console.ReadLine();
        }
    }
}
