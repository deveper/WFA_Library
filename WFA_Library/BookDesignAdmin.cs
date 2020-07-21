using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Library.Models;
using WFA_Library.Context;
using MetroFramework.Controls;
using System.Xml.Linq;
using System.Collections;
using System.Windows.Documents;
using System.Data.Entity;

namespace WFA_Library
{
    public partial class BookDesignAdmin : MetroForm
    {
        public BookDesignAdmin()
        {
            InitializeComponent();
        }
        Services services = new Services();

        #region Listeleme

        void BookSearch()
        {
            mgDataBook.DataSource = services.GetBooks().Select(x => new
            {
                x.BookId,
                x.BookName,
                x.Isbn,
                x.AddedDate,
                x.ReleaseDate,
                x.TotalQuantity,
                x.Quantity,
                x.Booktype.TypeName,
                Authors = string.Join("-", x.AuthorBooks.Select(y => y.Author.AuthorName + "   " + y.Author.AuthorLastName).ToList())
                //string join liste içerisindeki elemanları bir separatör ile birleştirmek amcıyla kullanılır.
            }).ToList();
        }
        #endregion

        #region search
        void BookSearch(string param)
        {
            mgDataBook.DataSource = services.GetFilterBooks(param);
        }
        #endregion

        #region Space Control
        public int EmptyControl(Control.ControlCollection ctrl)
        {
            int drm = 0;
            foreach (Control item in ctrl)
            {
                if (item is MetroTextBox)
                {
                    if (String.IsNullOrEmpty(item.Text))
                    {
                        errorProvider1.SetError(item, "Empty Area...");
                        drm = 0;
                    }
                    else if (!String.IsNullOrEmpty(item.Text))
                    {
                        drm = drm + 1;
                    }

                }
            }
            return drm;
        }
        #endregion

        #region ClearMethod
        void ClearText(Control.ControlCollection ctrc)
        {
            foreach (Control control in ctrc)
            {
                if (control is MetroTextBox)
                {
                    MetroTextBox txt = (MetroTextBox)control;
                    txt.Clear();
                }
                else if (control is MetroDateTime)
                {
                    MetroDateTime mdt = (MetroDateTime)control;
                    mdt.Value = DateTime.Now;
                }
            }

        } 
        #endregion

        //Author author = new Author();
        //AuthorBook authorBook = new AuthorBook();
        private void mtbAdd_Click(object sender, EventArgs e)
        {

            if (EmptyControl(this.Controls) == 0)
            {
                MetroMessageBox.Show(this, "there are empty writing areas", "EMPTY INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning, height: 100);
                errorProvider1.Clear();
                ClearText(this.Controls);
            }
            else
            {
                errorProvider1.Clear();
                AuthorBook authorBook = new AuthorBook();
                Author author = new Author();
                Booktype booktype = new Booktype();
                Book book = new Book();
                book.BookName = txtName.Text;
                book.Isbn = txtIsbn.Text;
                book.TotalQuantity = txtTotalQuantity.Text;
                book.ReleaseDate = mdtReleaseDate.Value;
                book.BookTypeId = Convert.ToInt32(listBox2.SelectedValue);
                #region Book's author added
                foreach (var item in listBox1.SelectedItems)
                {
                    author = (Author)services.GetAuthors().Where(i => i.AuthorId == (int)item).FirstOrDefault();
                }
                book.AuthorBooks = new List<AuthorBook>
            {
                new AuthorBook
                {
                    Author= author,
                    Book = book
                }
            };
                #endregion

                bool result1 = services.AddBook(book);

                MetroMessageBox.Show(this, result1 ? "Book Added Succesfully" : "Error", "Info",
                MessageBoxButtons.OK, result1 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                BookSearch();
                ClearText(this.Controls);

            }

        }

        #region SearchTextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BookSearch(textBox1.Text);

        }
        #endregion


        private void BookDesign_Load(object sender, EventArgs e)
        {
            #region AuthorList
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            var alist = services.GetAuthors().Select(x => x.AuthorId).ToList();
            listBox1.DataSource = alist;
            #endregion

            #region BookTypeList
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            listBox2.DataSource = services.GetBookTypes();
            listBox2.ValueMember = "BookTypeId";
            listBox2.DisplayMember = "TypeName";
            #endregion


            BookSearch();
        }

        #region BookDetailsBtnNavi
        private void metroButton1_Click(object sender, EventArgs e)
        {
            BookTypeDetailsDesing bookTypeDetails = new BookTypeDetailsDesing();
            this.Hide();
            bookTypeDetails.Show();
        }
        #endregion

        #region AuthorDetailsBtnNavi
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            AuthorDetailsDesign authorDetailsDesign = new AuthorDetailsDesign();
            this.Hide();
            authorDetailsDesign.Show();
        }


        #endregion


    }
}

