using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Stadium
    {
        public Stadium()
        {
            Clubs = new HashSet<Club>();
        }

        public int StadiumId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Club> Clubs { get; set; }
    }
}
