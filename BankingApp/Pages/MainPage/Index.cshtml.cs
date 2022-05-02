using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BankingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace BankingApp.Pages.MainPage
{
    public class Index : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Index(ApplicationDbContext db)
        {
            _db = db;
        }
        public string Name { get; set; }
        public int AccountBankMoney { get; set; }
        
        
        
        public void OnGetMyAccount(string username)
        {
            var user = _db.Users.FirstOrDefault(x => x.Username == username);
            var character = _db.Characters.FirstOrDefault(x => x.UserId == user.Id);
            AccountBankMoney = (character != null) ? character.BankMoney : -1;
            Name = (character != null) ? character.Name : "N/A";
            
            Console.WriteLine(AccountBankMoney);
        }

        public async Task<IActionResult> OnPost(string username)
        {
             return RedirectToPage("SendMoney/Index", "SetName", new {name = Name});
        }
    }
}