namespace MessageBoard.Models
{
    public class Group
    {
      public Group()
        {
            this.Messages = new HashSet<Message>();
        }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupTag { get; set; }
    }
}

Tag (string, ex. politics, entertainment)