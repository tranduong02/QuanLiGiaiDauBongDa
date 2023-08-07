using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Player
    {
        public Player()
        {
            Cards = new HashSet<Card>();
            Goals = new HashSet<Goal>();
            Teams = new HashSet<Team>();
        }

        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public int? CountryId { get; set; }
        public string PositionId { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Image { get; set; }
        public int? ClubId { get; set; }

        public virtual PlayingPosition Position { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
