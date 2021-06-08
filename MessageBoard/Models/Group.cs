using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;


namespace MessageBoard.Models
{
    public class Group
    {
    //   public Group()
        // {
        //     this.Messages = new HashSet<Message>();
        // }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupTag { get; set; }
        public int UserId { get; set; }

        public virtual Message message {get; set;}
        // public virtual ICollection<Message> Messages { get; set; }
        public virtual User user {get; set;}
    }
}

// Tag (string, ex. politics, entertainment)