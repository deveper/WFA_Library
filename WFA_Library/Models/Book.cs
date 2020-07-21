using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Library.Models
{
    public class  Book
    {
        public Book()
        {
            this.AddedDate = DateTime.Now;
        }

        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime AddedDate { get; set; }//eklenme tarihi
        public DateTime ReleaseDate { get; set; }//basım yılı
        public string Isbn { get; set; }
        public string TotalQuantity { get; set; }//Toplam  bulunan adet
        public int Quantity { get; set; }//Anlık stok adeti
        public virtual Booktype Booktype { get; set; }//kitap tiplerinin kitap taplosunda gözükmesi için virtual işaretlenmeli
        public int BookTypeId { get; set; }

      
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }


        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
