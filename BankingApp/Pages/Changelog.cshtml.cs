using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BankingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace BankingApp.Pages
{
    public class Changelog : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Changelog(ApplicationDbContext db)
        {
            _db = db;
        }
        
        [BindProperty]
        public List<Models.Changelog> changelogs { get; set; }
        
        
        
        


        public void OnGet()
        {
            changelogs = _db.Changelog.ToList();
            foreach (var changelog in changelogs)
            {
                Console.WriteLine(changelog.ChangelogContent.ToString());
            }
        }
    }
}