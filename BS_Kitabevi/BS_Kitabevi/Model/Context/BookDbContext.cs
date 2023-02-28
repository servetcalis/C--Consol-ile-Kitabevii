using BS_Kitabevi.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Kitabevi.Model.Context
{
    internal class BookDbContext : DbContext
    {
        public BookDbContext() : base("myConnectionString")
        {
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
