using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;


            do
            {
                Console.Write("\nBir sayi giriniz= ");
                sayi = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nGirdiğiniz sayi= {0}", sayi);


                switch (sayi / 1000)
                {
                    case 9: Console.Write("\nDokuz bin "); break;
                    case 8: Console.Write("\nSekiz bin "); break;
                    case 7: Console.Write("\nYedi bin "); break;
                    case 6: Console.Write("\nAlti bin "); break;
                    case 5: Console.Write("\nBeş bin "); break;
                    case 4: Console.Write("\nDort bin "); break;
                    case 3: Console.Write("\nUc bin "); break;
                    case 2: Console.Write("\nIki bin "); break;
                    case 1: Console.Write("\nBin "); break;
                    default:
                        break;

                }

                switch ((sayi % 1000) / 100)
                {
                    case 9: Console.Write("dokuz yüz "); break;
                    case 8: Console.Write("sekiz yüz "); break;
                    case 7: Console.Write("yedi yüz "); break;
                    case 6: Console.Write("alti yüz "); break;
                    case 5: Console.Write("beş yüz "); break;
                    case 4: Console.Write("dört yüz "); break;
                    case 3: Console.Write("üc yüz "); break;
                    case 2: Console.Write("iki yüz "); break;
                    case 1: Console.Write("yüz "); break;
                    default:
                        break;
                }

                switch ((sayi % 100) / 10)
                {
                    case 9: Console.Write("doksan "); break;
                    case 8: Console.Write("seksen "); break;
                    case 7: Console.Write("yetmiş "); break;
                    case 6: Console.Write("altmış "); break;
                    case 5: Console.Write("elli "); break;
                    case 4: Console.Write("kırk "); break;
                    case 3: Console.Write("otuz "); break;
                    case 2: Console.Write("yirmi "); break;
                    case 1: Console.Write("on "); break;
                    default:
                        break;
                }

                switch ((sayi % 10))
                {
                    case 9: Console.Write("dokuz \n"); break;
                    case 8: Console.Write("sekiz \n"); break;
                    case 7: Console.Write("yedi \n"); break;
                    case 6: Console.Write("alti \n"); break;
                    case 5: Console.Write("beş \n"); break;
                    case 4: Console.Write("dort \n"); break;
                    case 3: Console.Write("uc \n"); break;
                    case 2: Console.Write("iki \n"); break;
                    case 1: Console.Write("bir \n"); break;
                    default:
                        break;
                }

                if (sayi == 0)
                {
                    Console.WriteLine("Sıfır");
                }

            } while (sayi >= 0 && sayi <= 9999);
        }
    }
}
