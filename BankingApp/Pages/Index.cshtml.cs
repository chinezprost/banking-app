using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace BankingApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db, ILogger<IndexModel> logger) // dependency injection
        {
            _db = db;
            _logger = logger;
        }
        
        private readonly ILogger<IndexModel> _logger;
        
        [BindProperty]
        public string usernameInput { get; set; }
        [BindProperty]
        public string passwordInput { get; set; }
       
        
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            var foundUser = await _db.User.FirstOrDefaultAsync(x => x.Username == usernameInput && x.Password == passwordInput);
            if (foundUser != null) {
                Console.WriteLine("found");
                return RedirectToPage("Changelog");
            }
            return Page();
        }
    }
}