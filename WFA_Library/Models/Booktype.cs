using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Library.Models
{

    public class Booktype
    {
        public Booktype()
        {
            this.TypeAddedDate = DateTime.Now;
        }
        public int BookTypeId { get; set; }
        public string TypeName { get; set; }
        public DateTime TypeAddedDate { get; set; }
        //public override string ToString()
        //{
        //    return this.TypeName;
        //}
    }
}
