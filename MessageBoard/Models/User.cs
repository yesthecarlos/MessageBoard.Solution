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
    }
}