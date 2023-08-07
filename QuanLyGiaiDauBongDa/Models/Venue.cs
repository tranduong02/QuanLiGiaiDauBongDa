using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Venue
    {
        public Venue()
        {
            Matches = new HashSet<Match>();
        }

        public int VenueId { get; set; }
        public string Name { get; set; }
        public int? AudienceCapacity { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
}
