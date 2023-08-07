using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Account
    {
        public Account()
        {
            RoleAccounts = new HashSet<RoleAccount>();
        }

        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public int? ClubId { get; set; }

        public virtual Club Club { get; set; }
        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }
    }
}
