using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyGiaiDauBongDa.Models
{
    public partial class Feedback
    {
        public string Username { get; set; }
        public string Problem { get; set; }
        public string Content { get; set; }
        public int RateId { get; set; }
        public int FeedbackId { get; set; }

        public virtual Rate Rate { get; set; }
    }
}
