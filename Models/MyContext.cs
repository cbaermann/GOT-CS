using Microsoft.EntityFrameworkCore;

namespace GOT.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users{get;set;}
        public DbSet<Show> Shows{get;set;}
        public DbSet<UserShow> UserShows{get;set;}
      
    }
}