using Microsoft.EntityFrameworkCore;

namespace BankingApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<User> User { get; set; }
        public DbSet<Changelog> Changelog { get; set; }
    }
    
    

}