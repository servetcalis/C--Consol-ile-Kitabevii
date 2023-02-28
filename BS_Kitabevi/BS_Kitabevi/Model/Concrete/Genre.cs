using BS_Kitabevi.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BS_Kitabevi.Model.Concrete
{
    internal class Genre : BaseClass<int>
    {
        [Required(ErrorMessage = "Lütfen tür bilgisi giriniz.")]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        internal void Yazdir()
        {
            Console.WriteLine($"Adı: {Name}\tOluşturma tarihi: " + CreatedDate.ToString("dd.MM.yyyy HH:mm:ss"));
        }
    }
}
