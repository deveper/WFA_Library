﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Library.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual Authorization Authorization { get; set; }
        public int AuthorizationId { get; set; }
        public virtual ICollection<UserBook> UserBooks { get; set; }

    }
}
