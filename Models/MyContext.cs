using Microsoft.EntityFrameworkCore;


namespace ActivityCenter.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Shindig> Shindigs { get; set; }
        public DbSet<User_Shindig> User_Shindigs { get; set; }
    }
}