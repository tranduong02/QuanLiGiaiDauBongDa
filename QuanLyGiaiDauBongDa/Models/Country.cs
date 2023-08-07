using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Country
    {
        public Country()
        {
            Clubs = new HashSet<Club>();
            Referees = new HashSet<Referee>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<Club> Clubs { get; set; }
        public virtual ICollection<Referee> Referees { get; set; }
    }
}
