using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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

        #region BookServices

        public bool DeleteBook(int deletedData)
        {
           
            Book _deletedData = _mycontext.Books.Find(deletedData);
            _mycontext.Books.Remove(_deletedData);
            return _mycontext.SaveChanges() > 0;
        }
        public bool AddBook(Book book)
        {
            _mycontext.Books.Add(book);
            return _mycontext.SaveChanges() > 0;
            //int recordcount = _mycontext.SaveChanges();
            //return recordcount > 0;//savechanges kaç adet  işlem yapıldığını gösterir
        }
        public List<Book> GetBooks()
        {
            return _mycontext.Books.Include(x => x.AuthorBooks).ToList();
        }
        public List<Book> GetFilterBooks(string param)
        {
            return _mycontext.Books.Where(x =>
            x.BookName.Contains(param) ||
            x.BookId.ToString().Contains(param) ||
            x.Isbn.Contains(param)
            ).ToList();
        }
        #endregion

        #region  UserServices
        public bool UserAdd(User user)
        {
            _mycontext.Users.Add(user);
            return _mycontext.SaveChanges() > 0;
        }
        #endregion

        #region AuthorServices
        public bool AuthorAdd(Author author)
        {
            _mycontext.Authors.Add(author);
            return _mycontext.SaveChanges() > 0;
        }
        public List<Author> GetAuthors()
        {
            return _mycontext.Authors.Include(x => x.AuthorBooks).ToList();
        }
        public List<Author> GetFilterAuthors(string param)
        {
            return _mycontext.Authors.Include(x => x.AuthorBooks).Where(x =>
            x.AuthorName.Contains(param) ||
            x.AuthorLastName.Contains(param)
            ).ToList();
        }

        #endregion

        #region BookTypeServices
        public bool BookTypeAdd(Booktype booktype)
        {
            _mycontext.Booktypes.Add(booktype);
            return _mycontext.SaveChanges() > 0;
        }
        public List<Booktype> GetBookTypes()
        {
            return _mycontext.Booktypes.ToList();
        }
        public List<Booktype> GetFilterBooktypes(string param)
        {
            return _mycontext.Booktypes.Where(x =>
            x.TypeName.Contains(param)
            ).ToList();
        }
        #endregion

    }
}
