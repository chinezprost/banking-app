using Microsoft.EntityFrameworkCore;

namespace BankingApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Changelog> Changelogs { get; set; }
        public DbSet<Character> Characters { get; set; }
        
    }
    
    

}