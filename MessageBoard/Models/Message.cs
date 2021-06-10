using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace MessageBoard.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        [Required]
        [Display(Name="Message")]
        public string MessageText { get; set; }
        public string MessageDate { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Group Group { get; set; }

        // public virtual ApplicationUser User { get; set; }
    }
}


