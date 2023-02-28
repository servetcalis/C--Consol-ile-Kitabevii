using BS_Kitabevi.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Kitabevi.Model.Concrete
{
    internal class Book : BaseClass<int>
    {
        [StringLength(200), Required(ErrorMessage = "Lütfen kitap ismini giriniz.")]
        public string Title { get; set; }
        [Range(0.0, 10000000.0, ErrorMessage = "Lütfen 1 ile 10000000 arasında bir değer giriniz.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Lütfen bir tür seçiniz.")]
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }
       
        public string WriterName { get; internal set; }
    }
}
