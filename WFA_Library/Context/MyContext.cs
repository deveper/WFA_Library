using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WFA_Library.Models;
using System.Data.Entity.Infrastructure;

namespace WFA_Library.Context
{
    class MyContext : DbContext
    {
        public MyContext()
            : base("Connection")
        {

        }
        
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Authorization> Authorizations { get; set; }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Booktype> Booktypes { get; set; }

        public virtual DbSet<UserBook>UserBooks { get; set; }
        public virtual DbSet<Author>Authors { get; set; }

        public virtual DbSet<AuthorBook> AuthorBooks { get; set; }


        protected override void//n to n ilişli db anahtar kelimeler belirlenmesi fluent api yöntemi
        OnModelCreating(DbModelBuilder dbModelBuilder)//.netframework için DbModelBuilder kullanılır .netcore da farklı
        {
            dbModelBuilder.Entity<AuthorBook>()
                .HasKey(x => new { x.BookId, x.AuthorId });//ilişkiyi oluşturacak anahtar kelimeler.
            dbModelBuilder.Entity<AuthorBook>()
                .HasRequired(x => x.Book)//book tablosundan gelecek 
                .WithMany(w => w.AuthorBooks)//authorbooks tablosunda birleşecek
                .HasForeignKey(x => x.BookId);//2. anahtar olarak bookıd kullanıcak
            dbModelBuilder.Entity<AuthorBook>()
                 .HasRequired(x => x.Author)
                 .WithMany(w => w.AuthorBooks)
                 .HasForeignKey(x => x.AuthorId);       
        }
    }
}
