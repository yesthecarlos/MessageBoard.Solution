using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace MessageBoard.Models

{
    public class User
    {
        public User()
        {
            this.Messages = new HashSet<Message>();
        }
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}