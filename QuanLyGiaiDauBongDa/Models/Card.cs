using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Card
    {
        public int PlayerId { get; set; }
        public int MatchId { get; set; }
        public int? CardTime { get; set; }
        public bool? CardType { get; set; }
        public int CardId { get; set; }

        public virtual Match Match { get; set; }
        public virtual Player Player { get; set; }
    }
}
