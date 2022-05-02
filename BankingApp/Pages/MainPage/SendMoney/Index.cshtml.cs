using System;
using System.Diagnostics;
using BankingApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankingApp.Pages.SendMoney
{
    public class Index : PageModel
    {
        private readonly ApplicationDbContext db;

        public Index(ApplicationDbContext _db)
        {
            db = _db;
        }
        
        public string currentUsername { get; set; }
        public void OnGetSetName(string username)
        {
            currentUsername = username;
            Console.WriteLine(currentUsername);

        }
    }
}