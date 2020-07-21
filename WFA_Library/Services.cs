using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Library.Context;
using WFA_Library.Models;

namespace WFA_Library
{
    class Services
    {
        private MyContext _mycontext;
        public Services()
        {
            _mycontext = new MyContext();

        }
        public bool Add_b_bt_a(Book book, Booktype booktype, Author author)
        {
            _mycontext.Books.Add(book);
            _mycontext.Booktypes.Add(booktype);
            _mycontext.Authors.Add(author);
            return _mycontext.SaveChanges() > 0;
        }
        public bool AddBook(Book book)
        {
            _mycontext.Books.Add(book);
            return _mycontext.SaveChanges() > 0;
            //int recordcount = _mycontext.SaveChanges();
            //return recordcount > 0;//savechanges kaç adet  işlem yapıldığını gösterir
        }

        public bool UserAdd(User user)
        {
            _mycontext.Users.Add(user);
            return _mycontext.SaveChanges() > 0;
        }
        public List<Book> GetFilterBooks(string param)
        {
            return _mycontext.Books.Where(x =>
            x.BookName.Contains(param) ||
            x.BookId.ToString().Contains(param) ||
            x.Isbn.Contains(param) 
            ).ToList();
        }
        public List<Book> GetBooks()
        {
            return _mycontext.Books.Include(x => x.AuthorBooks).ToList();
        }
        public List<Booktype> GetBookTypes()
        {
            return _mycontext.Booktypes.ToList();
        }
        public List<Author> GetAuthors()
        {
            return _mycontext.Authors.ToList();
        }

    }
}
