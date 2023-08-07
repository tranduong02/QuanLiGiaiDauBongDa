using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Goal
    {
        public int GoalId { get; set; }
        public int MatchId { get; set; }
        public int PlayerId { get; set; }
        public int? GoalTime { get; set; }

        public virtual Match Match { get; set; }
        public virtual Player Player { get; set; }
    }
}
