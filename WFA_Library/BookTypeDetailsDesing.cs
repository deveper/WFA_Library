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
using MetroFramework.Controls;
using MetroFramework;

namespace WFA_Library
{
    public partial class BookTypeDetailsDesing : MetroForm
    {
       
        public BookTypeDetailsDesing()
        {
            InitializeComponent();
        }
        Services services = new Services();

        #region ListGrid
        void ListGrid()
        {
            mtgBookTypeDetail.DataSource = services.GetBookTypes().ToList();
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

        #region search
        void BooktypeSearch(string param)
        {
            mtgBookTypeDetail.DataSource = services.GetFilterBooktypes(param);
        } 
        #endregion
        private void BookTypeDetailsDesing_Load(object sender, EventArgs e)
        {
            ListGrid();
        }

        private void mtbUpdate_Click(object sender, EventArgs e)
        {

        }

        private void mtbDelete_Click(object sender, EventArgs e)
        {

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
                Booktype booktype = new Booktype();
                booktype.TypeName = txtTypeName.Text;


                bool result = services.BookTypeAdd(booktype);
                MetroMessageBox.Show(this, result ? "Author Added Succesfully" : "Error", "Info",
                 MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                ListGrid();
                ClearText(this.Controls);
            }
        }

        #region searchbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BooktypeSearch(textBox1.Text);
        }
        #endregion

        #region NavigationBackBtn
        private void mtlBack_Click(object sender, EventArgs e)
        {
            BookDesignAdmin bookDesignAdmin = new BookDesignAdmin();
            this.Dispose();
            bookDesignAdmin.Show();
        } 
        #endregion
    }
}
