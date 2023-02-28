using BS_Kitabevi.Model.Abstract;
using BS_Kitabevi.Model.Concrete;
using BS_Kitabevi.Model.Context;
using BS_Kitabevi.Model.Extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Kitabevi.Model.AnaMenu
{
    internal class YoneticiKontrol
    {
        internal static void KitapDonate(string v)
        {
            throw new NotImplementedException();
        }

        internal static void KitapEkle(string baslik)
        {
            string onay = string.Empty;
            do
            {
                MenuBaslik.MenuBaslik_(baslik);
                using (var db = new BookDbContext())
                {
                    List<Book> kitaplar = new List<Book>();
                    Console.Write("Kitap Adını Girin: ");
                    string kitapAdi = Console.ReadLine();
                    Console.Write("Yazar Adını Girin: ");
                    string yazarAdi = Console.ReadLine();
                    Console.Write("Tür Id'si Girin: ");
                    int turId = int.Parse(Console.ReadLine());
                    Console.Write("Fiyatını Girin: ");
                    decimal fiyat = decimal.Parse(Console.ReadLine());
                    kitaplar.Add(new Book
                    {
                        Title = kitapAdi,
                        WriterName = yazarAdi,
                        GenreId = turId,
                        Price = fiyat,
                        Status = StatuType.Active
                    });
                    db.Books.AddRange(kitaplar);

                    try
                    {
                        db.SaveChanges();
                        Console.WriteLine("Yeni Kitap Eklendi");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Hata Mesajı: " + e.Message);
                    }

                }
                Console.Write("Yeni Kitap eklemek ister misiniz?(evet -e)");

                onay = Console.ReadLine();

            } while (onay == "e" || onay == "E");
        }

        internal static void KitapFiyatAyarla(string baslik)
        {
            ConsoleKey onay;
            do
            {
                MenuBaslik.MenuBaslik_(baslik);
                Console.WriteLine("Fiyat revizyonu için,");
                Console.WriteLine();
                Console.Write("-Kitap ID'si girin: ");
                int kitapId = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Yeni Fiyat giriniz: ");
                decimal kitapFiyatiRevize = decimal.Parse(Console.ReadLine());
                using (var db = new BookDbContext())
                {
                    var kitapFiyati = db.Books.Find(kitapId);
                    kitapFiyati.Price = kitapFiyatiRevize;
                    try
                    {
                        db.SaveChanges();
                        Console.WriteLine($"{kitapFiyati.Title} kitabının fiyatı güncellendi.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hata Mesajı: " + e.Message);
                    }
                }
                Console.WriteLine();
                Console.Write("-Ana menüye dönmek için ESC'e basın.");
                onay = Console.ReadKey().Key;
            } while (onay != ConsoleKey.Escape);
        }

        internal static void KitapSil(string baslik)
        {
            ConsoleKey onay;
            do
            {
                MenuBaslik.MenuBaslik_(baslik);
                Console.Write("Silinecek Kitabın ID'sini girin: ");
                int kitapId = int.Parse(Console.ReadLine());
                using (var db = new BookDbContext())
                {
                    var kitapSil = db.Books.Find(kitapId);

                    kitapSil.IsDeleted = true;
                    kitapSil.DeletedDate = DateTime.Now;
                    try
                    {
                        db.SaveChanges();
                        Console.WriteLine();
                        Console.WriteLine($"{kitapSil.Title} kitabı silindi.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hata Mesajı: " + e.Message);
                    }
                }
                Console.WriteLine();
                Console.Write("-Ana menüye dönmek için ESC'e basın.");
                onay = Console.ReadKey().Key;
            } while (onay != ConsoleKey.Escape);
        }
    }
}
