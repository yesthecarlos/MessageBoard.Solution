using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        [Required]
        [Display(Name="Author")]
        public string MessageAuthor { get; set; }
        public string MessageText { get; set; }
        public datetime MessageDate { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }

            public virtual ApplicationUser User { get; set; }
    }
}


