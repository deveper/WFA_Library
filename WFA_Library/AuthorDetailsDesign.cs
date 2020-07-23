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
using Services;
using WFA_Library.Models;
using MetroFramework;
using MetroFramework.Controls;

namespace WFA_Library
{
    public partial class AuthorDetailsDesign : MetroForm
    {
        public AuthorDetailsDesign()
        {
            InitializeComponent();
        }
        Services services = new Services();

        #region List
        void ListGrid()
        {
            mtgAuthorDetail.DataSource = services.GetAuthors().Select(x => new
            {
                x.AuthorId,
                x.AuthorName,
                x.AuthorLastName,
                Books = string.Join("-", x.AuthorBooks.Select(y => y.Book.BookName).ToList())
            }).ToList();
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
            }
        }
        #endregion

        #region search
        void AuthorSearch(string param)
        {
            mtgAuthorDetail.DataSource = services.GetFilterAuthors(param);
        }
        #endregion

        #region Space Control
        int EmptyControl(Control.ControlCollection ctrl)
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
        private void AuthorDetailsDesign_Load(object sender, EventArgs e)
        {

            ListGrid();
        }

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
                Author author = new Author();
                author.AuthorName = txtAuthorName.Text;
                author.AuthorLastName = txtAuthorLastName.Text;


                bool result = services.AuthorAdd(author);
                MetroMessageBox.Show(this, result ? "Author Added Succesfully" : "Error", "Info",
                 MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                ListGrid();
                ClearText(this.Controls);
            }

        }

        #region SearchBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AuthorSearch(textBox1.Text);
        }
        #endregion

        #region  NavigationBackBtn
        private void mtlBack_Click(object sender, EventArgs e)
        {
            BookDesignAdmin bookDesignAdmin = new BookDesignAdmin();
            this.Dispose();
            bookDesignAdmin.Show();
        } 
        #endregion
    }
}
