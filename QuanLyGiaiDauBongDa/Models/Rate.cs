using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Rate
    {
        public Rate()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int RateId { get; set; }
        public string RateName { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
