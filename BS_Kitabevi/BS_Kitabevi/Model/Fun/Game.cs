using BS_Kitabevi.Model.Extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Kitabevi.Model.Fun
{
    internal class Game
    {
        internal static void Oyun(string baslik)
        {
            int puan = 250, tahminHak = 5, tahminAdet = 0, tahmin = 0, rasgeleSayi = 0;
            string cevap = "";

            MenuBaslik.MenuBaslik_(baslik);
            do
            {
                Console.Clear();
                Random rnd = new Random();
                rasgeleSayi = rnd.Next(1, 101);
                puan -= 50;
                tahminAdet = 0;
                tahmin = 0;

                Console.WriteLine("Sayı Tahmin Oyunu");
                Console.WriteLine("----------------------");
                Console.WriteLine("* 1 ile 100 arası bir sayı giriniz *");
                Console.WriteLine();
                Console.WriteLine(" -5 hakkınız var, başlangıç için 250 puan bakiyeniz vardır");
                Console.WriteLine(" -bilemediğiniz de 50 puan bakiyenizden düşecektir, kazandığınzda ise 100 puan kazanacaksınız.");
                Console.WriteLine();
                Console.WriteLine("Bakiyeniz: " + puan);


                for (int i = 1; i <= tahminHak; i++)
                {
                    bool hata = false;
                    do
                    {
                        Console.WriteLine();                                              
                        Console.Write(i + ". tahmininiz: ");
                        try
                        {
                            tahmin = int.Parse(Console.ReadLine());
                            if (tahmin >= 1 && tahmin <= 100)
                            {
                                hata = false;
                                tahminAdet++;
                            }
                            else
                            {
                                hata = true;
                                Console.WriteLine("Lütfen 1 ile 100 arasında bir değer giriniz.");
                                Console.WriteLine();
                            }
                        }
                        catch
                        {
                            hata = true;
                            Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                            Console.WriteLine();
                        }
                    } while (hata);


                    if (tahmin == rasgeleSayi)
                    {
                        Console.WriteLine($"Tebrikler! {tahminAdet}. tahminde sayıyı buldunuz.");
                        Console.WriteLine("Kazanılan puan: 100");
                        puan += 100;
                        break;
                    }
                    else if (tahmin > rasgeleSayi)
                    {
                        Console.WriteLine("Daha küçük bir tahminde bulunun.");
                    }
                    else
                    {
                        Console.WriteLine("Daha büyük bir tahminde bulunun.");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Mevcut Puan: " + puan);
                Console.WriteLine();

                if (puan >= 50)
                {
                    Console.Write("Yeni oyuna başlamak ister misiniz?(e) :");
                    cevap = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Krediniz yetersiz olduğu için yeni oyuna başlayamazsınız.");
                    cevap = "";
                }

            } while (cevap == "e" || cevap == "E");

            Console.WriteLine();
            Console.WriteLine("Programı kullandığınız için teşekkür ederiz.");
            Console.WriteLine("Programı kapatmak için bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
