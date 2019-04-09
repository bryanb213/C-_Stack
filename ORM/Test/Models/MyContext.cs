using Microsoft.EntityFrameworkCore;

namespace Test.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Eventss { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }
    }
}