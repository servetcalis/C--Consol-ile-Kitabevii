using BS_Kitabevi.Model.Fun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Kitabevi.Model.AnaMenu
{
    internal class Anasayfa
    {
        internal static void AnaMenu(ConsoleKey komut)
        {
            switch (komut)
            {
                case ConsoleKey.D1:
                    KullaniciSayfa.KitapAra("Ada göre Arama Sonuçları: ");
                    break;
                case ConsoleKey.D2:
                    KullaniciSayfa.IdArama("Id'e Göre Arama Sonuçları");
                    break;
                case ConsoleKey.D3:
                    KullaniciSayfa.YazaraGore("Yazara göre Arama Sonuçları: ");
                    break;
                case ConsoleKey.D4:
                    KullaniciSayfa.KitapFiyatId("Kitap ID - Fiyat Sonuçları: ");
                    break;
                case ConsoleKey.D5:
                    KullaniciSayfa.KitapListesi("Kitap - Tür Listeleme Sonuçları: ");
                    break;
                case ConsoleKey.D6:
                    KullaniciSayfa.KitapDonate("Kitap Bağışlama: ");
                    break;
                case ConsoleKey.D7:
                    KullaniciSayfa.KitapSat("Kitap Satış Talebi: ");
                    break;
                case ConsoleKey.D8:
                    KullaniciSayfa.Roman_Dergi("Çizgi Roman ve Dergi: ");
                    break;
                case ConsoleKey.D9:
                    Game.Oyun("Sayı Tahmin Oyunu: ");
                    break;
                case ConsoleKey.D0:
                    YoneticiSayfa.YoneticiPaneli("Yönetici Paneli", komut);
                    break;
                default:
                    break;
            }
        }
    }
}
