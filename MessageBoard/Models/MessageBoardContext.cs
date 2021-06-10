using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;
using System.Linq;

namespace MessageBoard.Models
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        // public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<User>()
        //     .HasMany<Message>(g => g.Messages)
        //     .WithOne(s => s.UserId == UserId)
        //     .WillCascadeOnDelete();

            // .builder.Entity<
            // builder.Entity<Message>()
            // .HasData(
            //     new Message { MessageId=1, MessageText= "Testing: Did this work?", MessageDate = "06-08-2021"},
            //     new Message { MessageId=2, MessageText= "Again Testing: What will happen?", MessageDate = "06-04-2021"},
            //     new Message { MessageId=3, MessageText= "Hopefully?", MessageDate = "06-07-2021"}
            // );
        }
    }
