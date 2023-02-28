using BS_Kitabevi.Model.Extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Kitabevi.Model.AnaMenu
{
    internal class YoneticiSayfa
    {
        internal static void YoneticiPaneli(string baslik, ConsoleKey komut)
        {
            ConsoleKey karar;

            do
            {
                MenuBaslik.MenuBaslik_(baslik);
                string kullaniciAdmin = "admin", sifreAdmin = "1234", kullaniciAdi, sifre;
                Console.Write("Kullanıcı Adı: ");
                kullaniciAdi = Console.ReadLine();
                Console.Write("Şifre: ");
                sifre = Console.ReadLine();

                if (sifreAdmin == sifre && kullaniciAdmin == kullaniciAdi)
                {
                    MenuBaslik.MenuBaslik_(baslik);
                    Console.WriteLine("-1 Kitap Ekle");
                    Console.WriteLine("-2 Kitap Sil");
                    Console.WriteLine("-3 Kitap Güncelle");
                    Console.WriteLine("-4 Kitap Bağış Listesi");
                    Console.WriteLine();
                    Console.WriteLine("-ESC Ana menüye dön");
                    Console.WriteLine();
                    Console.WriteLine("-Merhaba Yönetici, HoşGeldin");
                    Console.Write("-Hangi Alanda İşlem Yapmak İstersin?: ");
                    komut = Console.ReadKey().Key;
                    switch (komut)
                    {
                        case ConsoleKey.D1:
                            YoneticiKontrol.KitapEkle("Kitap Ekle");
                            break;
                        case ConsoleKey.D2:
                            YoneticiKontrol.KitapSil("Kitap Sil");
                            break;
                        case ConsoleKey.D3:
                            YoneticiKontrol.KitapFiyatAyarla("Kitap Güncelle");
                            break;
                        case ConsoleKey.D4:
                            YoneticiKontrol.KitapDonate("Kitap Bağış Listesi");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Kullanıcı Adı veya Şifre hatalı ***");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-Tekrar işlem yapmak için Enter'a basın.");
                Console.WriteLine("-Ana menüye dönmek için ESC'e basın.");
                karar = Console.ReadKey().Key;
                Console.WriteLine();

            } while (karar != ConsoleKey.Escape);
        }
    }
}
