using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entitiy<Message>()
            .HasData(
                new Message { MessageText= "Testing: Did this work?", MessageDate = "06-08-2021", GroupId=0, UserId=0}
                new Message { MessageText= "Again Testing: What will happen?", MessageDate = "06-04-2021", GroupId=1, UserId=1}
                new Message { MessageText= "Hopefully?", MessageDate = "06-07-2021", GroupId=0, UserId=1}
            )
        }
    }
}