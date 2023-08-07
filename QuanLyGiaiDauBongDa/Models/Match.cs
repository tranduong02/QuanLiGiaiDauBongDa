using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Match
    {
        public Match()
        {
            Cards = new HashSet<Card>();
            Goals = new HashSet<Goal>();
            MatchResults = new HashSet<MatchResult>();
            Teams = new HashSet<Team>();
        }

        public int MatchId { get; set; }
        public DateTime? PlayDate { get; set; }
        public int HostId { get; set; }
        public int GuestId { get; set; }
        public int RefereeId { get; set; }
        public int? TourseasonId { get; set; }
        public string PlayStage { get; set; }
        public int? VenueId { get; set; }

        public virtual Club Guest { get; set; }
        public virtual Club Host { get; set; }
        public virtual Referee Referee { get; set; }
        public virtual Venue Venue { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<MatchResult> MatchResults { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
