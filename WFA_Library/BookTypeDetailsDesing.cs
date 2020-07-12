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

namespace WFA_Library
{
    public partial class BookTypeDetailsDesing : MetroForm
    {
        Services services = new Services();
        public BookTypeDetailsDesing()
        {
            InitializeComponent();
        }

        private void BookTypeDetailsDesing_Load(object sender, EventArgs e)
        {
            #region DataGrid
            mtgBookTypeDetail.DataSource = services.GetBookTypes();
            #endregion
        }

        private void mtbUpdate_Click(object sender, EventArgs e)
        {

        }

        private void mtbDelete_Click(object sender, EventArgs e)
        {

        }

        private void mtbAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
