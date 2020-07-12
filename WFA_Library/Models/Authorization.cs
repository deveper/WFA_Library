using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Library.Models
{
    public class Authorization
    {
        public int AuthorizationId { get; set; }
        public string AuthorizationName { get; set; }
        public bool Add { get; set; }
        public bool Delete { get; set; }
        public bool Update { get; set; }
        public bool UserOpen { get; set; }
        public bool DeleteUser { get; set; }
        public bool Seaarch { get; set; }
    }
}
