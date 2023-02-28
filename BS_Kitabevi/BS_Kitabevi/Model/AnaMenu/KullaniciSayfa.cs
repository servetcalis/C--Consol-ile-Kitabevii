using BS_Kitabevi.Model.Context;
using BS_Kitabevi.Model.Extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BS_Kitabevi.Model.Extensions;
using System.Globalization;

namespace BS_Kitabevi.Model.AnaMenu
{
    internal class KullaniciSayfa
    {


        internal static void KitapDonate(string v)
        {
            throw new NotImplementedException();
        }

        internal static void KitapFiyatId(string baslik)
        {
            ConsoleKey karar;
            do
            {
                MenuBaslik.MenuBaslik_(baslik);

                using (var db = new BookDbContext())
                {
                    var books = db.Books.Where(b => b.Title.Contains(" "));

                    foreach (var book in books)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Kitap: " + book.Title);
                        Console.WriteLine("Fiyatı: " + book.Price + "TL");
                        Console.WriteLine("Durum: " + book.Status.GetStatu());
                        Console.WriteLine("Kitap Id: " + book.Id);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("-Ana menüye dönmek için ESC'e basın.");
                karar = Console.ReadKey().Key;
            } while (karar != ConsoleKey.Escape);
        }

        internal static void KitapListesi(string baslik)
        {
            ConsoleKey karar;
            do
            {
                MenuBaslik.MenuBaslik_(baslik);

                using (var db = new BookDbContext())
                {
                    var genreList = db.Genres.Include(x => x.Books);

                    foreach (var genre in genreList)
                    {
                        Console.WriteLine("Tür Adı: " + genre.Name + " - Kitap Sayısı: " + genre.Books.Count);
                        Console.WriteLine("----------------------------------------");
                        foreach (var book in genre.Books)
                        {
                            Console.WriteLine("Kitap: " + book.Title);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("-Ana menüye dönmek için ESC'e basın.");
                karar = Console.ReadKey().Key;
            } while (karar != ConsoleKey.Escape);
        }

        internal static void KitapSat(string v)
        {
            throw new NotImplementedException();
        }

        internal static void Roman_Dergi(string v)
        {
            throw new NotImplementedException();
        }

        internal static void KitapAra(string baslik)
        {
            ConsoleKey onay;
            do
            {
                MenuBaslik.MenuBaslik_(baslik);
                Console.WriteLine("Aramak istediğiniz kitabın,");
                Console.WriteLine();
                Console.Write("  Adını Giriniz: ");
                string kitapAdi = Console.ReadLine().Trim();

                using (var db = new BookDbContext())
                {
                    var kitapBul = db.Books.Where(x => x.Title.ToLower().Contains(kitapAdi.ToLower()));
                    if (!kitapBul.Any())
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sonuç bulunamadı.");
                    }
                    else
                    {
                        foreach (var kitap in kitapBul)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Kitap adı: " + kitap.Title);
                            Console.WriteLine("Yazar adı: " + kitap.WriterName);
                            Console.WriteLine("Fiyat: " + kitap.Price);
                        }
                    }
                }
                Console.WriteLine();
                Console.Write("-Ana menüye dönmek için ESC'e basın.");
                onay = Console.ReadKey().Key;
            } while (onay != ConsoleKey.Escape);
        }

        internal static void YazaraGore(string baslik)
        {
            ConsoleKey onay;

            do
            {
                MenuBaslik.MenuBaslik_(baslik);
                using (var db = new BookDbContext())
                {
                    var kategoriler = db.Books.GroupBy(g => g.WriterName);

                    foreach (var kategori in kategoriler)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Yazar: " + kategori.Key);
                        Console.WriteLine("--------------------------------");
                        foreach (var kitap in kategori)
                        {
                            Console.WriteLine("Kitap: " + kitap.Title);
                            Console.WriteLine("Fiyat: " + kitap.Price);
                            Console.WriteLine("Durum: " + kitap.Status);
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine();
                Console.Write("-Ana menüye dönmek için ESC'e basın.");
                onay = Console.ReadKey().Key;
            } while (onay != ConsoleKey.Escape);
        }

        internal static void IdArama(string baslik)
        {
            ConsoleKey onay;
            do
            {
                MenuBaslik.MenuBaslik_(baslik);
                Console.WriteLine("Aramak istediğiniz,");
                Console.WriteLine();
                Console.Write("    Kitap ID'i Giriniz: ");
                int arama = int.Parse(Console.ReadLine());
                using (var db = new BookDbContext())
                {
                    Console.WriteLine();
                    var book = db.Books.Find(arama);
                    if (book == null)
                    {
                        Console.WriteLine("Kitap bulunamadı.");
                    }
                    else
                    {
                        Console.WriteLine("Ad: " + book.Title);
                        Console.WriteLine("Fiyatı: " + book.Price + "TL");
                        Console.WriteLine("Durum: " + book.Status.GetStatu());
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("-Ana menüye dönmek için ESC'e basın.");                   
                }
                onay = Console.ReadKey().Key;
            } while (onay != ConsoleKey.Escape);
        }
    }
}
