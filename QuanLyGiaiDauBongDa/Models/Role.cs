using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleAccounts = new HashSet<RoleAccount>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }
    }
}
