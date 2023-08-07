using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class PlayingPosition
    {
        public PlayingPosition()
        {
            Players = new HashSet<Player>();
        }

        public string PositionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
