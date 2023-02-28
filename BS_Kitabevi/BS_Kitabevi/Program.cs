using BS_Kitabevi.Model.Abstract;
using BS_Kitabevi.Model.AnaMenu;
using BS_Kitabevi.Model.Concrete;
using BS_Kitabevi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Kitabevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey komut, karar;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("                        ********** BS KİTABEVİ **********                  ");
                    Console.WriteLine();
                    Console.WriteLine("- Kitaplığa HoşGeldiniz 2. El birçok türde kitabı burda uygun fiyata bulabilirsiniz");
                    Console.WriteLine("- Sıfıra yakın kitaplarımız muadillerinin altında olup Kargo ücretide fiyattan düşülmüştür");
                    Console.WriteLine();

                    Console.WriteLine("                      ********** İşlemler Menüsü **********                ");
                    Console.WriteLine();
                    Console.WriteLine("-1 Kitap Ara");
                    Console.WriteLine("-2 ID'e göre Ara");
                    Console.WriteLine("-3 Yazara göre Ara");
                    Console.WriteLine("-4 Kitap ID - Fiyat Listesi");
                    Console.WriteLine("-5 Tür - Kitap Listesi");
                    Console.WriteLine("-6 Kitap Bağışla");
                    Console.WriteLine("-7 Kitap Sat (kitaplarınızı değerlendiriyoruz)");
                    Console.WriteLine("-8 Çizgi-Roman ve Dergi"); 
                    Console.WriteLine("-9 Sayı Tahmin Oyunu (hediyeli)");
                    Console.WriteLine();
                    Console.WriteLine("-ESC Programı Kapat");
                    Console.WriteLine();
                    Console.WriteLine("-0 Yönetici Paneli");
                    Console.WriteLine();


                    Console.Write("-Yapmak istediğiniz işlemin numarasını seçiniz: ");
                    komut = Console.ReadKey().Key;

                    Console.WriteLine();
                    Anasayfa.AnaMenu(komut);

                } while (komut != ConsoleKey.Escape);

                Console.WriteLine();

                Console.Write("Program kapansın mı?(evet -e) (hayır -h)");
                karar = Console.ReadKey().Key;
                Console.WriteLine();

            } while (karar != ConsoleKey.E);


        }
    }
}
