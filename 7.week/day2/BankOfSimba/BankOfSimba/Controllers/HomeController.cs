using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        [Route("Simba")]
        
        // GET: /<controller>/
        public IActionResult Index()
        {     
            return View(bankAccount);
        }

        BankAccount bankAccount = new BankAccount("Simba", 2000, "Lion");

        public string ShowBankAccount()
        {     
            return $"{bankAccount.Name} has {bankAccount.Balance} and it's a {bankAccount.AnimalType}.";
        }
    }
}
