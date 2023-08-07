using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Referee
    {
        public Referee()
        {
            Matches = new HashSet<Match>();
        }

        public int RefereeId { get; set; }
        public string RefereeName { get; set; }
        public int? CountryId { get; set; }
        public DateTime? Dob { get; set; }
        public string Image { get; set; }
        public int? YearStarted { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
    }
}
