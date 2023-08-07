using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class RoleAccount
    {
        public int RoleId { get; set; }
        public string Username { get; set; }

        public virtual Role Role { get; set; }
        public virtual Account UsernameNavigation { get; set; }
    }
}
