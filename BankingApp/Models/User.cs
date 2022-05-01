using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public float Money { get; set; }
        
        public bool IsDeveloper { get; set; }
        
    }
}