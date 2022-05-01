using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class Changelog
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Version { get; set; }
        
        public string ChangelogContent { get; set; }
    }
}