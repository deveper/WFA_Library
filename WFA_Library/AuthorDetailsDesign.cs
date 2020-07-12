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
namespace WFA_Library
{
    public partial class AuthorDetailsDesign : MetroForm
    {
        public AuthorDetailsDesign()
        {
            InitializeComponent();
        }
        Services services = new Services();
        private void AuthorDetailsDesign_Load(object sender, EventArgs e)
        {
            #region DataGrid
            mtgAuthorDetail.DataSource = services.GetAuthors().Select(x => new {
                x.AuthorId,
                x.AuthorName,
                x.AuthorLastName
            }).ToList();
            #endregion

        }

      
    }
}
